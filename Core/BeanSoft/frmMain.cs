using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using AppClient.Controls;
using AppClient.Interface;
using AppClient.Utils;
using Core.Common;
using Core.Controllers;
using Core.Entities;
using Core.Utils;
using DevExpress.XtraBars.Docking;

namespace AppClient
{
    public partial class frmMain : XtraForm, IMain
    {
        internal MainProcess Process { get; set; }
        BarManagerCategory m_RootCategory;

        public frmMain()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLanguage();
                InitializeMenu();
            }

            Process = new MainProcess(this);
        }

        public void InitializeMenu()
        {
            ((IMain)this).InitializeMenu();
        }

        #region IMain Interface
        MainProcess IMain.Process { get { return Process; } }
        IMainLanguage IMain.Language { get { return Language; } }
        void IMain.InitializeMenu()
        {
            Dictionary<string, BarItem> dicMenuItems;
            List<MenuItemInfo> colMenuItems;
            Dictionary<string, BarManagerCategory> colMenuCategories;

            dicMenuItems = new Dictionary<string, BarItem>();
            colMenuCategories = new Dictionary<string, BarManagerCategory>();

            mainBar.Items.Clear();
            mainBar.Images = ThemeUtils.Image16;

            using (var ctrlMenu = new SAController())
            {
                ctrlMenu.ListMenuItems(out colMenuItems);
            }
            // 1st) Add root
            m_RootCategory = new BarManagerCategory
                                 {
                                     Name = LangUtils.Translate(
                                        LangType.MENU_CAPTION,
                                        CONSTANTS.BUILT_IN_MENU_NAME,
                                        CONSTANTS.BUILT_IN_MENU_NAME)
                                 };
            colMenuCategories.Add(CONSTANTS.BUILT_IN_MENU_ID, m_RootCategory);
            mainBar.Categories.Add(m_RootCategory);
            // 2nd) add root container
            BarItem newBarItem = new BarSubItem
                                     {
                                         Name = string.Format(CONSTANTS.BAR_SUB_ITEM_FORMAT, CONSTANTS.BUILT_IN_MENU_NAME),
                                         Caption = LangUtils.Translate(
                                                LangType.MENU_CAPTION,
                                                CONSTANTS.BUILT_IN_MENU_NAME,
                                                CONSTANTS.BUILT_IN_MENU_NAME)
                                     };
            dicMenuItems.Add(CONSTANTS.BUILT_IN_MENU_ID, newBarItem);

            foreach (MenuItemInfo item in colMenuItems)
            {
                var count = colMenuItems.Count(child => child.OwnerMenuItemID == item.MenuItemID);
                // No child create BarButtonItem, have children create Category
                if (count == 0)
                {
                    newBarItem = new BarButtonItem {Tag = item};
                    dicMenuItems.Add(item.MenuItemID, newBarItem);
                    newBarItem.Name = string.Format(CONSTANTS.BAR_BUTTON_ITEM_FORMAT, item.MenuItemName);
                }
                else
                {
                    newBarItem = new BarSubItem
                                     {
                                         Name = string.Format(CONSTANTS.BAR_SUB_ITEM_FORMAT, item.MenuItemName)
                                     };
                    dicMenuItems.Add(item.MenuItemID, newBarItem);

                    var category = new BarManagerCategory
                                       {
                                           Name = LangUtils.Translate(
                                               LangType.MENU_CAPTION,
                                               item.MenuItemName,
                                               item.MenuItemName)
                                       };
                    colMenuCategories.Add(item.MenuItemID, category);
                    mainBar.Categories.Add(category);
                }
                
                newBarItem.Tag = item;//Make tag
                newBarItem.Caption = LangUtils.Translate(LangType.MENU_CAPTION, item.MenuItemName);// Apply caption
                newBarItem.Glyph = LangUtils.Get16x16Image(LangType.MENU_ICON, item.MenuItemName);
                newBarItem.ItemShortcut = LangUtils.GetShortcut(LangType.MENU_HOTKEY, item.MenuItemName);

                mainBar.Items.Add(newBarItem);
            }

            foreach (MenuItemInfo item in colMenuItems)
            {
                if (!string.IsNullOrEmpty(item.OwnerMenuItemID))
                {
                    dicMenuItems[item.MenuItemID].Category = colMenuCategories[item.OwnerMenuItemID];
                    ((BarSubItem)dicMenuItems[item.OwnerMenuItemID]).LinksPersistInfo.Add(
                        new LinkPersistInfo(dicMenuItems[item.MenuItemID], item.BeginGroup == Core.CODES.DEFMENU.BEGINGROUP.YES));
                }
            }

            mainBar.Items.Add(txtModuleID);
        }

        void IMain.ApplyMenu()
        {
            mainMenu.ItemLinks.Clear();

            foreach (BarItem item in mainBar.Items)
            {
                var menuItemInfo = item.Tag as MenuItemInfo;
                if (menuItemInfo != null && !string.IsNullOrEmpty(menuItemInfo.ModuleID))
                {
                    var module = ModuleUtils.GetModuleInfo(menuItemInfo.ModuleID, menuItemInfo.SubModule);

                    if(!string.IsNullOrEmpty(module.RoleID))
                    {
                        var role = (from Role r in MainProcess.Roles
                                    where r.RoleID == module.RoleID
                                    select r).FirstOrDefault();
                        if (role != null && role.RoleValue != "Y")
                        {
                            item.Visibility = BarItemVisibility.Never;
                        }
                        else
                        {
                            item.Visibility = BarItemVisibility.Always;
                        }
                    }
                }
            }

            var count = m_RootCategory.GetItemCount();
            for (int i = 0; i < count; i++)
            {
                mainMenu.ItemLinks.Add(m_RootCategory.GetItem(i));
            }

            var isStop = false;
            
            foreach (var barItem in mainBar.Items)
            {
                if (barItem is BarSubItem)
                {
                    (barItem as BarSubItem).Visibility = BarItemVisibility.Always;
                }
            }
            
            while (!isStop)
            {
                isStop = true;
                foreach (BarItem barItem in mainBar.Items)
                {
                    if (barItem is BarSubItem && (barItem as BarSubItem).Visibility == BarItemVisibility.Always)
                    {
                        var isVisible = false;
                        foreach (LinkPersistInfo link in (barItem as BarSubItem).LinksPersistInfo)
                        {
                            if (link.Item.Visibility == BarItemVisibility.Always) isVisible = true;
                        }

                        if (!isVisible)
                        {
                            (barItem as BarSubItem).Visibility = BarItemVisibility.Never;
                            isStop = false;
                        }
                    }
                }
            }
#if DEBUG
            mainMenu.ItemLinks.Add(txtModuleID);
#endif
            try
            {
                using (var ctrlSA = new SAController())
                {
                    User userInfo;
                    ctrlSA.GetSessionUserInfo(out userInfo);
                }
            }
            catch (FaultException ex)
            {
                frmInfo.ShowError(Language.ApplicationTitle, ex, this);
            }
            catch (Exception ex)
            {
                frmInfo.ShowError(Language.ApplicationTitle, ErrorUtils.CreateErrorWithSubMessage(ERR_SYSTEM.ERR_SYSTEM_UNKNOWN, ex.Message), this);
            }
        }

        void IMain.OnLogout()
        {
            mainMenu.ItemLinks.Clear();
            mainStatusBar.ItemLinks.Clear();
        }
        
        void IMain.StartupModules()
        {
            Process.StartupModules();
        }

        XtraTabPage IMain.AddTabModule(XtraTabPage tabPage)
        {
            tabMain.TabPages.Add(tabPage);
            tabMain.SelectedTabPage = tabPage;
            return tabPage;
        }

        void IMain.SelectTabPage(XtraTabPage tabPage)
        {
            tabMain.SelectedTabPage = tabPage;
        }

        void IMain.RemoveTabModule(XtraTabPage tabPage)
        {
            tabMain.TabPages.Remove(tabPage);
        }

        void IMain.AddModulePreview(ucModulePreview preview)
        {
            JobQueue.SuspendLayout();
            JobQueue.Controls.Add(preview);
            preview.Dock = DockStyle.Top;
            JobQueue.Visibility = DockVisibility.Visible;
            JobQueue.ResumeLayout();
        }

        void IMain.RegisterButton(BarButtonItem button)
        {
            mainStatusBar.ItemLinks.Clear();
            mainBar.Items.Add(button);
            mainStatusBar.ItemLinks.Add(button);
        }

        void IMain.CancelRegisterButton(BarButtonItem button)
        {
            if (button.Links.Count > 0)
            {
                mainStatusBar.ItemLinks.Remove(button.Links[0]);
            }
        }

        void IMain.RemoveModulePreview(ucModulePreview preview)
        {
            JobQueue.Controls.Remove(preview);
            preview.Dispose();
        }
        #endregion

        #region Properties & Members
        public WorkerThread CurrentThread { get; set; }
        #endregion

        #region Events

        private void tabMain_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.PrevPage != null) e.PrevPage.Controls[0].Enabled = false;
            if (e.Page != null) e.Page.Controls[0].Enabled = true;
        }

        private void tabMain_CloseButtonClick(object sender, EventArgs e)
        {
            var evt = e as ClosePageButtonEventArgs;
            if (evt != null)
            {
                var page = evt.Page as XtraTabPage;
                if (page != null)
                    if (page.Controls.Count > 0)
                    {
                        ((ucModule) page.Tag).CloseModule();
                    }
            }
        }

        private void mainBar_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainProcess.ExecuteMenu(e.Item.Name, e.Item.Tag as MenuItemInfo);
        }

        private void txtModuleID_EditValueChanged(object sender, EventArgs e)
        {
            if (txtModuleID.EditValue != null)
            {
                var moduleID = txtModuleID.EditValue.ToString().ToUpper();
                txtModuleID.EditValue = null;

                MainProcess.ExecuteModule(moduleID);
            }
        }

        #endregion

        #region Overloads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = Language.ApplicationTitle;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            frmSplash.CloseForm();
            Activate();
            MainProcess.ShowLogin();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (App.Environment.ClientInfo.SessionKey == null || frmConfirm.ShowConfirm(Language.ExitTitle, Language.ExitConfirm, this))
            {
                MainProcess.LogoutFromSystem(false);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == Win32.WM_COPYDATA && msg.WParam == Handle)
            {
                var fileInfo = (Win32.COPYDATASTRUCT)msg.GetLParam(typeof(Win32.COPYDATASTRUCT));
                Process.InstallModule(fileInfo.m_LpData);
            }
            base.WndProc(ref msg);
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
            MainProcess.LogoutFromSystem(false);
        }
        #endregion
    }
}
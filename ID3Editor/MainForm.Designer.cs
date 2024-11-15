﻿using System.Windows.Forms;
using System.ComponentModel;

namespace TagEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && (_presenter != null) )
            {
                _presenter.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this._mainMenuItem = new System.Windows.Forms.MenuItem();
            this._scanMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this._mainListBox = new System.Windows.Forms.ListBox();
            this._listBoxContextMenu = new System.Windows.Forms.ContextMenu();
            this._editListBoxMenuItem = new System.Windows.Forms.MenuItem();
            this._advancedEditListBoxMenuItem = new System.Windows.Forms.MenuItem();
            this._compactListBoxMenuItem = new System.Windows.Forms.MenuItem();
            this._launchListBoxMenuItem = new System.Windows.Forms.MenuItem();
            this._removeV2tag = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._mainMenuItem,
            this.menuItem2});
            // 
            // _mainMenuItem
            // 
            this._mainMenuItem.Index = 0;
            this._mainMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._scanMenuItem});
            this._mainMenuItem.Text = "Файл";
            // 
            // _scanMenuItem
            // 
            this._scanMenuItem.Index = 0;
            this._scanMenuItem.Text = "Сканировать директорию";
            this._scanMenuItem.Click += new System.EventHandler(this._scanMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
            this.menuItem2.Text = "О программе";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Cправка";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "О программе";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // _mainListBox
            // 
            this._mainListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainListBox.ContextMenu = this._listBoxContextMenu;
            this._mainListBox.ItemHeight = 16;
            this._mainListBox.Location = new System.Drawing.Point(10, 9);
            this._mainListBox.Name = "_mainListBox";
            this._mainListBox.Size = new System.Drawing.Size(653, 372);
            this._mainListBox.TabIndex = 0;
            this._mainListBox.DoubleClick += new System.EventHandler(this._mainListBox_DoubleClick);
            this._mainListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._mainListBox_MouseDown);
            // 
            // _listBoxContextMenu
            // 
            this._listBoxContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._editListBoxMenuItem,
            this._advancedEditListBoxMenuItem,
            this._compactListBoxMenuItem,
            this._launchListBoxMenuItem,
            this._removeV2tag});
            // 
            // _editListBoxMenuItem
            // 
            this._editListBoxMenuItem.Index = 0;
            this._editListBoxMenuItem.Text = "Редактировать";
            this._editListBoxMenuItem.Click += new System.EventHandler(this._mainListBoxMenu_EditTag);
            // 
            // _advancedEditListBoxMenuItem
            // 
            this._advancedEditListBoxMenuItem.Index = 1;
            this._advancedEditListBoxMenuItem.Text = "Развитый редактор";
            this._advancedEditListBoxMenuItem.Click += new System.EventHandler(this._mainListBoxMenu_EditExtendedTag);
            // 
            // _compactListBoxMenuItem
            // 
            this._compactListBoxMenuItem.Index = 2;
            this._compactListBoxMenuItem.Text = "Компактный";
            this._compactListBoxMenuItem.Click += new System.EventHandler(this._mainListBoxMenu_Compact);
            // 
            // _launchListBoxMenuItem
            // 
            this._launchListBoxMenuItem.Index = 3;
            this._launchListBoxMenuItem.Text = "Воспроизвести";
            this._launchListBoxMenuItem.Click += new System.EventHandler(this._mainListBoxMenu_Launch);
            // 
            // _removeV2tag
            // 
            this._removeV2tag.Index = 4;
            this._removeV2tag.Text = "Удалить все теги";
            this._removeV2tag.Click += new System.EventHandler(this._removeV2tag_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(672, 387);
            this.Controls.Add(this._mainListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "Загрузка файлов";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }
        #endregion

        #region fields
        protected System.Windows.Forms.MainMenu _mainMenu;
        protected System.Windows.Forms.MenuItem _mainMenuItem;
        protected System.Windows.Forms.MenuItem _scanMenuItem;
        protected System.Windows.Forms.ListBox _mainListBox;
        protected System.Windows.Forms.ContextMenu _listBoxContextMenu;
        protected System.Windows.Forms.MenuItem _editListBoxMenuItem;
        protected System.Windows.Forms.MenuItem _advancedEditListBoxMenuItem;
        protected System.Windows.Forms.MenuItem _compactListBoxMenuItem;
        protected System.Windows.Forms.MenuItem _launchListBoxMenuItem;
        #endregion
        private MenuItem _removeV2tag;
        private MenuItem menuItem2;
        private MenuItem menuItem1;
        private MenuItem menuItem3;
    }
}
// Copyright(C) 2002-2003 Hugo Rumayor Montemayor, All rights reserved.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Id3Lib;
using Id3Lib.Frames;

namespace TagEditor
{
	/// <summary>
	/// Advanced ID3 Edit
	/// </summary>
	public class ID3PowerEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView _treeView;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Tag Model reference
		/// </summary>
		private TagModel _tagModel = null;
        private System.Windows.Forms.Button button1;
        private Button button2;

		/// <summary>
		/// Hash to get repeating tag frames
		/// </summary>
		private Hashtable _hash = new Hashtable();

		public ID3PowerEdit()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public TagModel TagModel
		{
			set{_tagModel = value;}
			get{return _tagModel;}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID3PowerEdit));
            this._treeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _treeView
            // 
            this._treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._treeView.Location = new System.Drawing.Point(10, 9);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(548, 337);
            this._treeView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(240, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.Click += new System.EventHandler(this.On);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(355, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // ID3PowerEdit
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(568, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ID3PowerEdit";
            this.Text = "ID3 Power Edit";
            this.Load += new System.EventHandler(this.ID3PowerEdit_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void ID3PowerEdit_Load(object sender, System.EventArgs e)
		{
			foreach(var frameBase in _tagModel)
			{
				TreeNode node = null;
				if(_hash.Contains(frameBase.FrameId))
				{
					node = (TreeNode)_hash[frameBase.FrameId];
				}
				else
				{
                    node = new TreeNode(FrameDescription.GetDescription(frameBase.FrameId));
					_hash.Add(frameBase.FrameId,node);
					_treeView.Nodes.Add(node);
				}
				node.Nodes.Add(new TreeNode(frameBase.ToString()));
			}
		}

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void On(object sender, EventArgs e)
        {

        }
	}
}

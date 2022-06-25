using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMasterExtended
{
    partial class frmBlacklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlacklist));
            this.lstBlacklist = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAppid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.brnTumunuSil = new System.Windows.Forms.Button();
            this.lblSay = new System.Windows.Forms.Label();
            this.btnDisaAktar = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBlacklist
            // 
            this.lstBlacklist.FormattingEnabled = true;
            this.lstBlacklist.Location = new System.Drawing.Point(13, 39);
            this.lstBlacklist.Name = "lstBlacklist";
            this.lstBlacklist.Size = new System.Drawing.Size(300, 394);
            this.lstBlacklist.Sorted = true;
            this.lstBlacklist.TabIndex = 0;
            this.lstBlacklist.SelectedIndexChanged += new System.EventHandler(this.lstBlacklist_SelectedIndexChanged);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtAppid);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Location = new System.Drawing.Point(13, 439);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(181, 76);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Game to Blacklist";
            this.grpAdd.Enter += new System.EventHandler(this.grpAdd_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAppid
            // 
            this.txtAppid.Location = new System.Drawing.Point(56, 17);
            this.txtAppid.Name = "txtAppid";
            this.txtAppid.Size = new System.Drawing.Size(119, 20);
            this.txtAppid.TabIndex = 0;
            this.txtAppid.TextChanged += new System.EventHandler(this.txtAppid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(238, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = global::IdleMasterExtended.Properties.Resources.imgTrash;
            this.btnRemove.Location = new System.Drawing.Point(270, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(12, 10);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 4;
            this.btnAc.Text = "Open";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // brnTumunuSil
            // 
            this.brnTumunuSil.Location = new System.Drawing.Point(189, 10);
            this.brnTumunuSil.Name = "brnTumunuSil";
            this.brnTumunuSil.Size = new System.Drawing.Size(75, 23);
            this.brnTumunuSil.TabIndex = 5;
            this.brnTumunuSil.Text = "Clear All";
            this.brnTumunuSil.UseVisualStyleBackColor = true;
            this.brnTumunuSil.Click += new System.EventHandler(this.brnTumunuSil_Click);
            // 
            // lblSay
            // 
            this.lblSay.AutoSize = true;
            this.lblSay.Location = new System.Drawing.Point(278, 439);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(0, 13);
            this.lblSay.TabIndex = 6;
            // 
            // btnDisaAktar
            // 
            this.btnDisaAktar.Location = new System.Drawing.Point(93, 10);
            this.btnDisaAktar.Name = "btnDisaAktar";
            this.btnDisaAktar.Size = new System.Drawing.Size(75, 23);
            this.btnDisaAktar.TabIndex = 7;
            this.btnDisaAktar.Text = "Export";
            this.btnDisaAktar.UseVisualStyleBackColor = true;
            this.btnDisaAktar.Click += new System.EventHandler(this.btnDisaAktar_Click);
            // 
            // frmBlacklist
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 522);
            this.Controls.Add(this.btnDisaAktar);
            this.Controls.Add(this.lblSay);
            this.Controls.Add(this.brnTumunuSil);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lstBlacklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBlacklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Blacklist";
            this.Load += new System.EventHandler(this.frmBlacklist_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBlacklist;
        private GroupBox grpAdd;
        private Button btnRemove;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtAppid;
        private Label label1;
        private Button btnAc;
        private Button brnTumunuSil;
        private Label lblSay;
        private Button btnDisaAktar;
    }
}
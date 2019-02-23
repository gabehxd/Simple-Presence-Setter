namespace Simple_Presence_Setter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autocheck = new System.Windows.Forms.CheckBox();
            this.Largekey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Largetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Smalltext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Smallkey = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.set_btn = new System.Windows.Forms.Button();
            this.clientid = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Toolbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.ShouldMini = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // autocheck
            // 
            this.autocheck.AutoSize = true;
            this.autocheck.Enabled = false;
            this.autocheck.Location = new System.Drawing.Point(88, 371);
            this.autocheck.Name = "autocheck";
            this.autocheck.Size = new System.Drawing.Size(131, 17);
            this.autocheck.TabIndex = 0;
            this.autocheck.Text = "Auto update presence";
            this.autocheck.UseVisualStyleBackColor = true;
            this.autocheck.CheckedChanged += new System.EventHandler(this.Autocheck_CheckedChanged);
            // 
            // Largekey
            // 
            this.Largekey.Enabled = false;
            this.Largekey.Location = new System.Drawing.Point(32, 206);
            this.Largekey.Name = "Largekey";
            this.Largekey.Size = new System.Drawing.Size(100, 20);
            this.Largekey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Large Image Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Large Image Text";
            // 
            // Largetext
            // 
            this.Largetext.Enabled = false;
            this.Largetext.Location = new System.Drawing.Point(178, 206);
            this.Largetext.Name = "Largetext";
            this.Largetext.Size = new System.Drawing.Size(100, 20);
            this.Largetext.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Small Image Text";
            // 
            // Smalltext
            // 
            this.Smalltext.Enabled = false;
            this.Smalltext.Location = new System.Drawing.Point(178, 134);
            this.Smalltext.Name = "Smalltext";
            this.Smalltext.Size = new System.Drawing.Size(100, 20);
            this.Smalltext.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Small Image Key";
            // 
            // Smallkey
            // 
            this.Smallkey.Enabled = false;
            this.Smallkey.Location = new System.Drawing.Point(32, 134);
            this.Smallkey.Name = "Smallkey";
            this.Smallkey.Size = new System.Drawing.Size(100, 20);
            this.Smallkey.TabIndex = 5;
            // 
            // details
            // 
            this.details.Enabled = false;
            this.details.Location = new System.Drawing.Point(102, 265);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(100, 20);
            this.details.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Details";
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(118, 454);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(75, 23);
            this.set_btn.TabIndex = 12;
            this.set_btn.Text = "Start";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // clientid
            // 
            this.clientid.Location = new System.Drawing.Point(105, 69);
            this.clientid.Name = "clientid";
            this.clientid.Size = new System.Drawing.Size(100, 20);
            this.clientid.TabIndex = 13;
            // 
            // update_btn
            // 
            this.update_btn.Enabled = false;
            this.update_btn.Location = new System.Drawing.Point(118, 425);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "State";
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(105, 327);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 20);
            this.state.TabIndex = 16;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(132, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Client ID";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Toolbar
            // 
            this.Toolbar.Icon = ((System.Drawing.Icon)(resources.GetObject("Toolbar.Icon")));
            this.Toolbar.Text = "Simple Presence Setter";
            this.Toolbar.Click += new System.EventHandler(this.NotifyIcon_MouseClick);
            // 
            // ShouldMini
            // 
            this.ShouldMini.AutoSize = true;
            this.ShouldMini.Location = new System.Drawing.Point(88, 394);
            this.ShouldMini.Name = "ShouldMini";
            this.ShouldMini.Size = new System.Drawing.Size(98, 17);
            this.ShouldMini.TabIndex = 19;
            this.ShouldMini.Text = "Minimize to tray";
            this.ShouldMini.UseVisualStyleBackColor = true;
            this.ShouldMini.CheckedChanged += new System.EventHandler(this.ShouldMini_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 552);
            this.Controls.Add(this.ShouldMini);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.state);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.clientid);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Smalltext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Smallkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Largetext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Largekey);
            this.Controls.Add(this.autocheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Presence Setter";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autocheck;
        private System.Windows.Forms.TextBox Largekey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Largetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Smalltext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Smallkey;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.TextBox clientid;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon Toolbar;
        private System.Windows.Forms.CheckBox ShouldMini;
    }
}


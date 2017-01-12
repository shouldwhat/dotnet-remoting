namespace Remoting_Client
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_age = new System.Windows.Forms.ComboBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.bt_registUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSITION : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGE : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEX : ";
            // 
            // cb_position
            // 
            this.cb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Location = new System.Drawing.Point(91, 35);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(121, 20);
            this.cb_position.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(91, 8);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 21);
            this.tb_name.TabIndex = 5;
            // 
            // cb_age
            // 
            this.cb_age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_age.FormattingEnabled = true;
            this.cb_age.Location = new System.Drawing.Point(91, 61);
            this.cb_age.Name = "cb_age";
            this.cb_age.Size = new System.Drawing.Size(121, 20);
            this.cb_age.TabIndex = 6;
            // 
            // cb_sex
            // 
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Location = new System.Drawing.Point(91, 87);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(121, 20);
            this.cb_sex.TabIndex = 7;
            // 
            // bt_registUser
            // 
            this.bt_registUser.Location = new System.Drawing.Point(1, 114);
            this.bt_registUser.Name = "bt_registUser";
            this.bt_registUser.Size = new System.Drawing.Size(222, 36);
            this.bt_registUser.TabIndex = 8;
            this.bt_registUser.Text = "regist user";
            this.bt_registUser.UseVisualStyleBackColor = true;
            this.bt_registUser.Click += new System.EventHandler(this.bt_registUser_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 155);
            this.Controls.Add(this.bt_registUser);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.cb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.cb_position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_age;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Button bt_registUser;
    }
}
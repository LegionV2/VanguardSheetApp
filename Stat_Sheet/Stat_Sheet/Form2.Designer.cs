namespace Stat_Sheet
{
    partial class Form2
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
            this.Previous_Page = new System.Windows.Forms.Button();
            this.label_back = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.label_Print = new System.Windows.Forms.Label();
            this.perk1_desc = new System.Windows.Forms.TextBox();
            this.label_perk1 = new System.Windows.Forms.Label();
            this.perk2_desc = new System.Windows.Forms.TextBox();
            this.label_perk2 = new System.Windows.Forms.Label();
            this.label_perkOP = new System.Windows.Forms.Label();
            this.perkOP_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.perk1_name = new System.Windows.Forms.TextBox();
            this.perk2_name = new System.Windows.Forms.TextBox();
            this.perkOP_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Previous_Page
            // 
            this.Previous_Page.Location = new System.Drawing.Point(26, 431);
            this.Previous_Page.Name = "Previous_Page";
            this.Previous_Page.Size = new System.Drawing.Size(75, 23);
            this.Previous_Page.TabIndex = 0;
            this.Previous_Page.Text = "Fall back!";
            this.Previous_Page.UseVisualStyleBackColor = true;
            this.Previous_Page.Click += new System.EventHandler(this.Previous_Page_Click);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.Location = new System.Drawing.Point(23, 415);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(97, 16);
            this.label_back.TabIndex = 1;
            this.label_back.Text = "Back to stats";
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(408, 431);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 2;
            this.button_print.Text = "Engage!";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // label_Print
            // 
            this.label_Print.AutoSize = true;
            this.label_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Print.Location = new System.Drawing.Point(376, 415);
            this.label_Print.Name = "label_Print";
            this.label_Print.Size = new System.Drawing.Size(107, 16);
            this.label_Print.TabIndex = 3;
            this.label_Print.Text = "Print dat sheet";
            // 
            // perk1_desc
            // 
            this.perk1_desc.Location = new System.Drawing.Point(12, 76);
            this.perk1_desc.Multiline = true;
            this.perk1_desc.Name = "perk1_desc";
            this.perk1_desc.Size = new System.Drawing.Size(210, 135);
            this.perk1_desc.TabIndex = 4;
            this.perk1_desc.Text = "Description";
            this.perk1_desc.TextChanged += new System.EventHandler(this.perk1_desc_TextChanged);
            // 
            // label_perk1
            // 
            this.label_perk1.AutoSize = true;
            this.label_perk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_perk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perk1.Location = new System.Drawing.Point(9, 57);
            this.label_perk1.Name = "label_perk1";
            this.label_perk1.Size = new System.Drawing.Size(77, 16);
            this.label_perk1.TabIndex = 5;
            this.label_perk1.Text = "Perk no. 1";
            // 
            // perk2_desc
            // 
            this.perk2_desc.Location = new System.Drawing.Point(273, 76);
            this.perk2_desc.Multiline = true;
            this.perk2_desc.Name = "perk2_desc";
            this.perk2_desc.Size = new System.Drawing.Size(210, 135);
            this.perk2_desc.TabIndex = 6;
            this.perk2_desc.Text = "Description";
            this.perk2_desc.TextChanged += new System.EventHandler(this.perk2_desc_TextChanged);
            // 
            // label_perk2
            // 
            this.label_perk2.AutoSize = true;
            this.label_perk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_perk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perk2.Location = new System.Drawing.Point(270, 57);
            this.label_perk2.Name = "label_perk2";
            this.label_perk2.Size = new System.Drawing.Size(77, 16);
            this.label_perk2.TabIndex = 7;
            this.label_perk2.Text = "Perk no. 2";
            // 
            // label_perkOP
            // 
            this.label_perkOP.AutoSize = true;
            this.label_perkOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_perkOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perkOP.Location = new System.Drawing.Point(112, 237);
            this.label_perkOP.Name = "label_perkOP";
            this.label_perkOP.Size = new System.Drawing.Size(65, 16);
            this.label_perkOP.TabIndex = 9;
            this.label_perkOP.Text = "OP Perk";
            // 
            // perkOP_desc
            // 
            this.perkOP_desc.Location = new System.Drawing.Point(115, 256);
            this.perkOP_desc.Multiline = true;
            this.perkOP_desc.Name = "perkOP_desc";
            this.perkOP_desc.Size = new System.Drawing.Size(256, 135);
            this.perkOP_desc.TabIndex = 8;
            this.perkOP_desc.Text = "Description";
            this.perkOP_desc.TextChanged += new System.EventHandler(this.perkOP_desc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Perk Page! Write your perk descriptions here.\r\nOr not! They are completly optiona" +
    "l.";
            // 
            // perk1_name
            // 
            this.perk1_name.Location = new System.Drawing.Point(93, 57);
            this.perk1_name.Name = "perk1_name";
            this.perk1_name.Size = new System.Drawing.Size(129, 20);
            this.perk1_name.TabIndex = 11;
            this.perk1_name.Text = "Name";
            this.perk1_name.TextChanged += new System.EventHandler(this.perk1_name_TextChanged);
            // 
            // perk2_name
            // 
            this.perk2_name.Location = new System.Drawing.Point(354, 57);
            this.perk2_name.Name = "perk2_name";
            this.perk2_name.Size = new System.Drawing.Size(129, 20);
            this.perk2_name.TabIndex = 12;
            this.perk2_name.Text = "Name";
            this.perk2_name.TextChanged += new System.EventHandler(this.perk2_name_TextChanged);
            // 
            // perkOP_name
            // 
            this.perkOP_name.Location = new System.Drawing.Point(183, 237);
            this.perkOP_name.Name = "perkOP_name";
            this.perkOP_name.Size = new System.Drawing.Size(129, 20);
            this.perkOP_name.TabIndex = 13;
            this.perkOP_name.Text = "Name";
            this.perkOP_name.TextChanged += new System.EventHandler(this.perkOP_name_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stat_Sheet.Properties.Resources.parcment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 507);
            this.Controls.Add(this.perkOP_name);
            this.Controls.Add(this.perk2_name);
            this.Controls.Add(this.perk1_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_perkOP);
            this.Controls.Add(this.perkOP_desc);
            this.Controls.Add(this.label_perk2);
            this.Controls.Add(this.perk2_desc);
            this.Controls.Add(this.label_perk1);
            this.Controls.Add(this.perk1_desc);
            this.Controls.Add(this.label_Print);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.Previous_Page);
            this.Name = "Form2";
            this.Text = "Perks Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_Close);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Previous_Page;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label_Print;
        private System.Windows.Forms.TextBox perk1_desc;
        private System.Windows.Forms.Label label_perk1;
        private System.Windows.Forms.TextBox perk2_desc;
        private System.Windows.Forms.Label label_perk2;
        private System.Windows.Forms.Label label_perkOP;
        private System.Windows.Forms.TextBox perkOP_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox perk1_name;
        private System.Windows.Forms.TextBox perk2_name;
        private System.Windows.Forms.TextBox perkOP_name;
    }
}
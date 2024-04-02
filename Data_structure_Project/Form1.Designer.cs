namespace Data_structure_Project
{
    partial class Flight_Form
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txt_flightName = new System.Windows.Forms.TextBox();
            this.cmb_Source = new System.Windows.Forms.ComboBox();
            this.cmb_Dest = new System.Windows.Forms.ComboBox();
            this.txt_seatNo = new System.Windows.Forms.TextBox();
            this.dateTime_takeOff = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Information:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(139, 377);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 51);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Source:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Take off Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Seats:";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(512, 377);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 51);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Ba&ck";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(328, 377);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(150, 51);
            this.btn_Del.TabIndex = 8;
            this.btn_Del.Text = "&Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_flightName
            // 
            this.txt_flightName.Location = new System.Drawing.Point(264, 91);
            this.txt_flightName.Name = "txt_flightName";
            this.txt_flightName.Size = new System.Drawing.Size(191, 26);
            this.txt_flightName.TabIndex = 9;
            // 
            // cmb_Source
            // 
            this.cmb_Source.FormattingEnabled = true;
            this.cmb_Source.Items.AddRange(new object[] {
            "Calgary YYC",
            "Montreal YUL",
            "Ottawa YOW",
            "Toronto YYZ",
            "Vancouver YVR",
            "",
            ""});
            this.cmb_Source.Location = new System.Drawing.Point(265, 161);
            this.cmb_Source.Name = "cmb_Source";
            this.cmb_Source.Size = new System.Drawing.Size(190, 28);
            this.cmb_Source.TabIndex = 10;
            // 
            // cmb_Dest
            // 
            this.cmb_Dest.FormattingEnabled = true;
            this.cmb_Dest.Items.AddRange(new object[] {
            "Heathrow Airport",
            "Los Angeles Airport",
            "Sydney Int\'l Airport",
            "Paris CDG",
            "Goa Airport"});
            this.cmb_Dest.Location = new System.Drawing.Point(264, 216);
            this.cmb_Dest.Name = "cmb_Dest";
            this.cmb_Dest.Size = new System.Drawing.Size(190, 28);
            this.cmb_Dest.TabIndex = 11;
            // 
            // txt_seatNo
            // 
            this.txt_seatNo.Location = new System.Drawing.Point(265, 323);
            this.txt_seatNo.Name = "txt_seatNo";
            this.txt_seatNo.Size = new System.Drawing.Size(65, 26);
            this.txt_seatNo.TabIndex = 12;
            // 
            // dateTime_takeOff
            // 
            this.dateTime_takeOff.Location = new System.Drawing.Point(265, 266);
            this.dateTime_takeOff.Name = "dateTime_takeOff";
            this.dateTime_takeOff.Size = new System.Drawing.Size(190, 26);
            this.dateTime_takeOff.TabIndex = 13;
            // 
            // Flight_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTime_takeOff);
            this.Controls.Add(this.txt_seatNo);
            this.Controls.Add(this.cmb_Dest);
            this.Controls.Add(this.cmb_Source);
            this.Controls.Add(this.txt_flightName);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Name = "Flight_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Addition Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_flightName;
        private System.Windows.Forms.ComboBox cmb_Source;
        private System.Windows.Forms.ComboBox cmb_Dest;
        private System.Windows.Forms.TextBox txt_seatNo;
        private System.Windows.Forms.DateTimePicker dateTime_takeOff;
    }
}


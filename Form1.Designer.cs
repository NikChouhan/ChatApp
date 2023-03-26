namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textPortHost = new TextBox();
            textIPHost = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textPortClient = new TextBox();
            textIPClient = new TextBox();
            messageBox = new TextBox();
            convoBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textPortHost);
            groupBox1.Controls.Add(textIPHost);
            groupBox1.Location = new Point(91, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 150);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Port Host";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 69);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "IP Host";
            // 
            // textPortHost
            // 
            textPortHost.Location = new Point(121, 147);
            textPortHost.Name = "textPortHost";
            textPortHost.Size = new Size(125, 27);
            textPortHost.TabIndex = 1;
            textPortHost.TextChanged += textBox2_TextChanged;
            // 
            // textIPHost
            // 
            textIPHost.Location = new Point(121, 62);
            textIPHost.Name = "textIPHost";
            textIPHost.Size = new Size(125, 27);
            textIPHost.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textPortClient);
            groupBox2.Controls.Add(textIPClient);
            groupBox2.Location = new Point(466, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 144);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Port Client";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 59);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "IP Client";
            // 
            // textPortClient
            // 
            textPortClient.Location = new Point(102, 137);
            textPortClient.Name = "textPortClient";
            textPortClient.Size = new Size(125, 27);
            textPortClient.TabIndex = 1;
            textPortClient.TextChanged += textBox4_TextChanged;
            // 
            // textIPClient
            // 
            textIPClient.Location = new Point(102, 56);
            textIPClient.Name = "textIPClient";
            textIPClient.Size = new Size(125, 27);
            textIPClient.TabIndex = 0;
            textIPClient.TextChanged += textBox3_TextChanged;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(91, 452);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(696, 27);
            messageBox.TabIndex = 2;
            messageBox.TextChanged += messageBox_TextChanged;
            // 
            // convoBox
            // 
            convoBox.FormattingEnabled = true;
            convoBox.ItemHeight = 20;
            convoBox.Location = new Point(91, 229);
            convoBox.Name = "convoBox";
            convoBox.Size = new Size(658, 184);
            convoBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(820, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(820, 450);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 510);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(convoBox);
            Controls.Add(messageBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textPortHost;
        private TextBox textIPHost;
        private GroupBox groupBox2;
        private TextBox textPortClient;
        private TextBox textIPClient;
        private TextBox messageBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private ListBox convoBox;
        private Button button1;
        private Button button2;
    }
}
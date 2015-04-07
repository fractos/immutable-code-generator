namespace WindowsImmutableCodeGenerator
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.textBoxNamespace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCollections = new System.Windows.Forms.ComboBox();
            this.buttonLoadCollection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.buttonLoadType = new System.Windows.Forms.Button();
            this.buttonSaveType = new System.Windows.Forms.Button();
            this.buttonNewCollection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(476, 6);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCode.Size = new System.Drawing.Size(615, 670);
            this.textBoxCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Properties:";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(82, 85);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(388, 20);
            this.textBoxClassName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Custom,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(82, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Custom
            // 
            this.Custom.HeaderText = "Custom";
            this.Custom.Name = "Custom";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "string",
            "int",
            "int16",
            "int32",
            "int64",
            "decimal",
            "double",
            "float",
            "DateTime",
            "bool"});
            this.Type.Name = "Type";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(82, 268);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "&Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Template:";
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(82, 33);
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(388, 20);
            this.textBoxTemplate.TabIndex = 0;
            this.textBoxTemplate.Text = "C:\\IPT\\extra\\ImmutableCodeGenerator\\templates\\full.template";
            // 
            // textBoxNamespace
            // 
            this.textBoxNamespace.Location = new System.Drawing.Point(82, 59);
            this.textBoxNamespace.Name = "textBoxNamespace";
            this.textBoxNamespace.Size = new System.Drawing.Size(388, 20);
            this.textBoxNamespace.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namespace:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Collection:";
            // 
            // comboBoxCollections
            // 
            this.comboBoxCollections.FormattingEnabled = true;
            this.comboBoxCollections.Location = new System.Drawing.Point(82, 6);
            this.comboBoxCollections.Name = "comboBoxCollections";
            this.comboBoxCollections.Size = new System.Drawing.Size(232, 21);
            this.comboBoxCollections.TabIndex = 10;
            // 
            // buttonLoadCollection
            // 
            this.buttonLoadCollection.Location = new System.Drawing.Point(395, 4);
            this.buttonLoadCollection.Name = "buttonLoadCollection";
            this.buttonLoadCollection.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadCollection.TabIndex = 11;
            this.buttonLoadCollection.Text = "&Load";
            this.buttonLoadCollection.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Types:";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(82, 297);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(307, 21);
            this.comboBoxTypes.TabIndex = 13;
            // 
            // buttonLoadType
            // 
            this.buttonLoadType.Location = new System.Drawing.Point(395, 295);
            this.buttonLoadType.Name = "buttonLoadType";
            this.buttonLoadType.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadType.TabIndex = 14;
            this.buttonLoadType.Text = "L&oad";
            this.buttonLoadType.UseVisualStyleBackColor = true;
            // 
            // buttonSaveType
            // 
            this.buttonSaveType.Location = new System.Drawing.Point(163, 268);
            this.buttonSaveType.Name = "buttonSaveType";
            this.buttonSaveType.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveType.TabIndex = 15;
            this.buttonSaveType.Text = "&Save";
            this.buttonSaveType.UseVisualStyleBackColor = true;
            // 
            // buttonNewCollection
            // 
            this.buttonNewCollection.Location = new System.Drawing.Point(320, 4);
            this.buttonNewCollection.Name = "buttonNewCollection";
            this.buttonNewCollection.Size = new System.Drawing.Size(69, 23);
            this.buttonNewCollection.TabIndex = 16;
            this.buttonNewCollection.Text = "&New";
            this.buttonNewCollection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 688);
            this.Controls.Add(this.buttonNewCollection);
            this.Controls.Add(this.buttonSaveType);
            this.Controls.Add(this.buttonLoadType);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLoadCollection);
            this.Controls.Add(this.comboBoxCollections);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNamespace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCode);
            this.Text = "Immutable Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.TextBox textBoxNamespace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomType;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCollections;
        private System.Windows.Forms.Button buttonLoadCollection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Button buttonLoadType;
        private System.Windows.Forms.Button buttonSaveType;
        private System.Windows.Forms.Button buttonNewCollection;
    }
}


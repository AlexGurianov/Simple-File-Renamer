namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.directory_path_textBox = new System.Windows.Forms.TextBox();
            this.to_lower_case_button = new System.Windows.Forms.Button();
            this.replace_button = new System.Windows.Forms.Button();
            this.old_text_textBox = new System.Windows.Forms.TextBox();
            this.new_text_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_instance_radioButton = new System.Windows.Forms.RadioButton();
            this.last_instance_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.instance_num_textBox = new System.Windows.Forms.TextBox();
            this.instance_num_radioButton = new System.Windows.Forms.RadioButton();
            this.all_instances_radioButton = new System.Windows.Forms.RadioButton();
            this.add_index_button = new System.Windows.Forms.Button();
            this.start_by_name_radioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.end_radioButton = new System.Windows.Forms.RadioButton();
            this.start_by_time_radioButton = new System.Windows.Forms.RadioButton();
            this.file_mask_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.replace_between_checkBox = new System.Windows.Forms.CheckBox();
            this.between_start_textBox = new System.Windows.Forms.TextBox();
            this.between_end_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.first_letter_upcase_checkBox = new System.Windows.Forms.CheckBox();
            this.first_letters_upcase_checkBox = new System.Windows.Forms.CheckBox();
            this.leave_first_letters_radioButton = new System.Windows.Forms.RadioButton();
            this.leave_first_letter_radioButton = new System.Windows.Forms.RadioButton();
            this.everything_radioButton = new System.Windows.Forms.RadioButton();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delete_num_textBox = new System.Windows.Forms.TextBox();
            this.end_delete_radioButton = new System.Windows.Forms.RadioButton();
            this.beginning_delete_radioButton = new System.Windows.Forms.RadioButton();
            this.file_name_textBox = new System.Windows.Forms.TextBox();
            this.choose_file_button = new System.Windows.Forms.Button();
            this.fill_from_file_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.choose_folder_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.first_last_index_radioButton = new System.Windows.Forms.RadioButton();
            this.first_index_radioButton = new System.Windows.Forms.RadioButton();
            this.no_index_radioButton = new System.Windows.Forms.RadioButton();
            this.fill_track_names_button = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.index_tracks_radioButton = new System.Windows.Forms.RadioButton();
            this.no_index_tracks_radioButton = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.delete_start_after_num_textBox = new System.Windows.Forms.TextBox();
            this.delete_after_char_radioButton = new System.Windows.Forms.RadioButton();
            this.delete_from_beginning_radioButton = new System.Windows.Forms.RadioButton();
            this.delete_repeating_start_button = new System.Windows.Forms.Button();
            this.add_zeros_button = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.back_radioButton = new System.Windows.Forms.RadioButton();
            this.front_radioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_blank_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder path:";
            // 
            // directory_path_textBox
            // 
            this.directory_path_textBox.Location = new System.Drawing.Point(133, 31);
            this.directory_path_textBox.Name = "directory_path_textBox";
            this.directory_path_textBox.Size = new System.Drawing.Size(547, 20);
            this.directory_path_textBox.TabIndex = 1;
            // 
            // to_lower_case_button
            // 
            this.to_lower_case_button.Location = new System.Drawing.Point(52, 218);
            this.to_lower_case_button.Name = "to_lower_case_button";
            this.to_lower_case_button.Size = new System.Drawing.Size(166, 61);
            this.to_lower_case_button.TabIndex = 2;
            this.to_lower_case_button.Text = "To lower case";
            this.to_lower_case_button.UseVisualStyleBackColor = true;
            this.to_lower_case_button.Click += new System.EventHandler(this.to_lower_case_button_Click);
            // 
            // replace_button
            // 
            this.replace_button.Location = new System.Drawing.Point(653, 99);
            this.replace_button.Name = "replace_button";
            this.replace_button.Size = new System.Drawing.Size(131, 65);
            this.replace_button.TabIndex = 3;
            this.replace_button.Text = "Replace";
            this.replace_button.UseVisualStyleBackColor = true;
            this.replace_button.Click += new System.EventHandler(this.replace_button_Click);
            // 
            // old_text_textBox
            // 
            this.old_text_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.old_text_textBox.Location = new System.Drawing.Point(132, 133);
            this.old_text_textBox.Name = "old_text_textBox";
            this.old_text_textBox.Size = new System.Drawing.Size(196, 20);
            this.old_text_textBox.TabIndex = 5;
            // 
            // new_text_textBox
            // 
            this.new_text_textBox.Location = new System.Drawing.Point(413, 133);
            this.new_text_textBox.Name = "new_text_textBox";
            this.new_text_textBox.Size = new System.Drawing.Size(218, 20);
            this.new_text_textBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Old text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New text:";
            // 
            // first_instance_radioButton
            // 
            this.first_instance_radioButton.AutoSize = true;
            this.first_instance_radioButton.BackColor = System.Drawing.SystemColors.Control;
            this.first_instance_radioButton.Location = new System.Drawing.Point(3, 4);
            this.first_instance_radioButton.Name = "first_instance_radioButton";
            this.first_instance_radioButton.Size = new System.Drawing.Size(87, 17);
            this.first_instance_radioButton.TabIndex = 9;
            this.first_instance_radioButton.Text = "First instance";
            this.first_instance_radioButton.UseVisualStyleBackColor = true;
            // 
            // last_instance_radioButton
            // 
            this.last_instance_radioButton.AutoSize = true;
            this.last_instance_radioButton.Location = new System.Drawing.Point(3, 27);
            this.last_instance_radioButton.Name = "last_instance_radioButton";
            this.last_instance_radioButton.Size = new System.Drawing.Size(88, 17);
            this.last_instance_radioButton.TabIndex = 10;
            this.last_instance_radioButton.Text = "Last instance";
            this.last_instance_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instance_num_textBox);
            this.panel1.Controls.Add(this.instance_num_radioButton);
            this.panel1.Controls.Add(this.all_instances_radioButton);
            this.panel1.Controls.Add(this.first_instance_radioButton);
            this.panel1.Controls.Add(this.last_instance_radioButton);
            this.panel1.Location = new System.Drawing.Point(793, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 96);
            this.panel1.TabIndex = 11;
            // 
            // instance_num_textBox
            // 
            this.instance_num_textBox.Location = new System.Drawing.Point(81, 51);
            this.instance_num_textBox.Name = "instance_num_textBox";
            this.instance_num_textBox.Size = new System.Drawing.Size(28, 20);
            this.instance_num_textBox.TabIndex = 19;
            this.instance_num_textBox.Text = "1";
            // 
            // instance_num_radioButton
            // 
            this.instance_num_radioButton.AutoSize = true;
            this.instance_num_radioButton.BackColor = System.Drawing.SystemColors.Control;
            this.instance_num_radioButton.Location = new System.Drawing.Point(3, 51);
            this.instance_num_radioButton.Name = "instance_num_radioButton";
            this.instance_num_radioButton.Size = new System.Drawing.Size(76, 17);
            this.instance_num_radioButton.TabIndex = 12;
            this.instance_num_radioButton.TabStop = true;
            this.instance_num_radioButton.Text = "Instance #";
            this.instance_num_radioButton.UseVisualStyleBackColor = false;
            // 
            // all_instances_radioButton
            // 
            this.all_instances_radioButton.AutoSize = true;
            this.all_instances_radioButton.Checked = true;
            this.all_instances_radioButton.Location = new System.Drawing.Point(3, 76);
            this.all_instances_radioButton.Name = "all_instances_radioButton";
            this.all_instances_radioButton.Size = new System.Drawing.Size(84, 17);
            this.all_instances_radioButton.TabIndex = 11;
            this.all_instances_radioButton.TabStop = true;
            this.all_instances_radioButton.Text = "All instances";
            this.all_instances_radioButton.UseVisualStyleBackColor = true;
            // 
            // add_index_button
            // 
            this.add_index_button.Location = new System.Drawing.Point(317, 216);
            this.add_index_button.Name = "add_index_button";
            this.add_index_button.Size = new System.Drawing.Size(131, 65);
            this.add_index_button.TabIndex = 12;
            this.add_index_button.Text = "Add index";
            this.add_index_button.UseVisualStyleBackColor = true;
            this.add_index_button.Click += new System.EventHandler(this.add_index_button_Click);
            // 
            // start_by_name_radioButton
            // 
            this.start_by_name_radioButton.AutoSize = true;
            this.start_by_name_radioButton.Checked = true;
            this.start_by_name_radioButton.Location = new System.Drawing.Point(3, 3);
            this.start_by_name_radioButton.Name = "start_by_name_radioButton";
            this.start_by_name_radioButton.Size = new System.Drawing.Size(93, 17);
            this.start_by_name_radioButton.TabIndex = 13;
            this.start_by_name_radioButton.TabStop = true;
            this.start_by_name_radioButton.Text = "Start; by name";
            this.start_by_name_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.end_radioButton);
            this.panel2.Controls.Add(this.start_by_time_radioButton);
            this.panel2.Controls.Add(this.start_by_name_radioButton);
            this.panel2.Location = new System.Drawing.Point(317, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 70);
            this.panel2.TabIndex = 14;
            // 
            // end_radioButton
            // 
            this.end_radioButton.AutoSize = true;
            this.end_radioButton.Location = new System.Drawing.Point(3, 45);
            this.end_radioButton.Name = "end_radioButton";
            this.end_radioButton.Size = new System.Drawing.Size(90, 17);
            this.end_radioButton.TabIndex = 15;
            this.end_radioButton.Text = "End; by name";
            this.end_radioButton.UseVisualStyleBackColor = true;
            // 
            // start_by_time_radioButton
            // 
            this.start_by_time_radioButton.AutoSize = true;
            this.start_by_time_radioButton.Location = new System.Drawing.Point(3, 24);
            this.start_by_time_radioButton.Name = "start_by_time_radioButton";
            this.start_by_time_radioButton.Size = new System.Drawing.Size(119, 17);
            this.start_by_time_radioButton.TabIndex = 14;
            this.start_by_time_radioButton.Text = "Start; by time added";
            this.start_by_time_radioButton.UseVisualStyleBackColor = true;
            // 
            // file_mask_textBox
            // 
            this.file_mask_textBox.Location = new System.Drawing.Point(132, 75);
            this.file_mask_textBox.Name = "file_mask_textBox";
            this.file_mask_textBox.Size = new System.Drawing.Size(131, 20);
            this.file_mask_textBox.TabIndex = 15;
            this.file_mask_textBox.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "File mask:";
            // 
            // replace_between_checkBox
            // 
            this.replace_between_checkBox.AutoSize = true;
            this.replace_between_checkBox.BackColor = System.Drawing.SystemColors.Control;
            this.replace_between_checkBox.Location = new System.Drawing.Point(74, 165);
            this.replace_between_checkBox.Name = "replace_between_checkBox";
            this.replace_between_checkBox.Size = new System.Drawing.Size(130, 17);
            this.replace_between_checkBox.TabIndex = 17;
            this.replace_between_checkBox.Text = "Replace text between";
            this.replace_between_checkBox.UseVisualStyleBackColor = true;
            // 
            // between_start_textBox
            // 
            this.between_start_textBox.Location = new System.Drawing.Point(210, 163);
            this.between_start_textBox.Name = "between_start_textBox";
            this.between_start_textBox.Size = new System.Drawing.Size(100, 20);
            this.between_start_textBox.TabIndex = 18;
            // 
            // between_end_textBox
            // 
            this.between_end_textBox.Location = new System.Drawing.Point(351, 163);
            this.between_end_textBox.Name = "between_end_textBox";
            this.between_end_textBox.Size = new System.Drawing.Size(100, 20);
            this.between_end_textBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "and";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.first_letter_upcase_checkBox);
            this.panel3.Controls.Add(this.first_letters_upcase_checkBox);
            this.panel3.Controls.Add(this.leave_first_letters_radioButton);
            this.panel3.Controls.Add(this.leave_first_letter_radioButton);
            this.panel3.Controls.Add(this.everything_radioButton);
            this.panel3.Location = new System.Drawing.Point(52, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 114);
            this.panel3.TabIndex = 21;
            // 
            // first_letter_upcase_checkBox
            // 
            this.first_letter_upcase_checkBox.AutoSize = true;
            this.first_letter_upcase_checkBox.Location = new System.Drawing.Point(38, 48);
            this.first_letter_upcase_checkBox.Name = "first_letter_upcase_checkBox";
            this.first_letter_upcase_checkBox.Size = new System.Drawing.Size(109, 17);
            this.first_letter_upcase_checkBox.TabIndex = 4;
            this.first_letter_upcase_checkBox.Text = "First letter upcase";
            this.first_letter_upcase_checkBox.UseVisualStyleBackColor = true;
            // 
            // first_letters_upcase_checkBox
            // 
            this.first_letters_upcase_checkBox.AutoSize = true;
            this.first_letters_upcase_checkBox.Location = new System.Drawing.Point(38, 94);
            this.first_letters_upcase_checkBox.Name = "first_letters_upcase_checkBox";
            this.first_letters_upcase_checkBox.Size = new System.Drawing.Size(114, 17);
            this.first_letters_upcase_checkBox.TabIndex = 3;
            this.first_letters_upcase_checkBox.Text = "First letters upcase";
            this.first_letters_upcase_checkBox.UseVisualStyleBackColor = true;
            // 
            // leave_first_letters_radioButton
            // 
            this.leave_first_letters_radioButton.AutoSize = true;
            this.leave_first_letters_radioButton.Location = new System.Drawing.Point(4, 71);
            this.leave_first_letters_radioButton.Name = "leave_first_letters_radioButton";
            this.leave_first_letters_radioButton.Size = new System.Drawing.Size(160, 17);
            this.leave_first_letters_radioButton.TabIndex = 2;
            this.leave_first_letters_radioButton.Text = "Leave first letters in all words";
            this.leave_first_letters_radioButton.UseVisualStyleBackColor = true;
            // 
            // leave_first_letter_radioButton
            // 
            this.leave_first_letter_radioButton.AutoSize = true;
            this.leave_first_letter_radioButton.Checked = true;
            this.leave_first_letter_radioButton.Location = new System.Drawing.Point(4, 28);
            this.leave_first_letter_radioButton.Name = "leave_first_letter_radioButton";
            this.leave_first_letter_radioButton.Size = new System.Drawing.Size(100, 17);
            this.leave_first_letter_radioButton.TabIndex = 1;
            this.leave_first_letter_radioButton.TabStop = true;
            this.leave_first_letter_radioButton.Text = "Leave first letter";
            this.leave_first_letter_radioButton.UseVisualStyleBackColor = true;
            // 
            // everything_radioButton
            // 
            this.everything_radioButton.AutoSize = true;
            this.everything_radioButton.Location = new System.Drawing.Point(4, 4);
            this.everything_radioButton.Name = "everything_radioButton";
            this.everything_radioButton.Size = new System.Drawing.Size(75, 17);
            this.everything_radioButton.TabIndex = 0;
            this.everything_radioButton.Text = "Everything";
            this.everything_radioButton.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(548, 227);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(131, 65);
            this.delete_button.TabIndex = 22;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.delete_num_textBox);
            this.panel4.Controls.Add(this.end_delete_radioButton);
            this.panel4.Controls.Add(this.beginning_delete_radioButton);
            this.panel4.Location = new System.Drawing.Point(711, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 54);
            this.panel4.TabIndex = 26;
            // 
            // delete_num_textBox
            // 
            this.delete_num_textBox.Location = new System.Drawing.Point(112, 17);
            this.delete_num_textBox.Name = "delete_num_textBox";
            this.delete_num_textBox.Size = new System.Drawing.Size(51, 20);
            this.delete_num_textBox.TabIndex = 2;
            // 
            // end_delete_radioButton
            // 
            this.end_delete_radioButton.AutoSize = true;
            this.end_delete_radioButton.Location = new System.Drawing.Point(3, 26);
            this.end_delete_radioButton.Name = "end_delete_radioButton";
            this.end_delete_radioButton.Size = new System.Drawing.Size(74, 17);
            this.end_delete_radioButton.TabIndex = 1;
            this.end_delete_radioButton.Text = "At the end";
            this.end_delete_radioButton.UseVisualStyleBackColor = true;
            // 
            // beginning_delete_radioButton
            // 
            this.beginning_delete_radioButton.AutoSize = true;
            this.beginning_delete_radioButton.Checked = true;
            this.beginning_delete_radioButton.Location = new System.Drawing.Point(3, 3);
            this.beginning_delete_radioButton.Name = "beginning_delete_radioButton";
            this.beginning_delete_radioButton.Size = new System.Drawing.Size(102, 17);
            this.beginning_delete_radioButton.TabIndex = 0;
            this.beginning_delete_radioButton.TabStop = true;
            this.beginning_delete_radioButton.Text = "At the beginning";
            this.beginning_delete_radioButton.UseVisualStyleBackColor = true;
            // 
            // file_name_textBox
            // 
            this.file_name_textBox.Location = new System.Drawing.Point(132, 449);
            this.file_name_textBox.Name = "file_name_textBox";
            this.file_name_textBox.Size = new System.Drawing.Size(547, 20);
            this.file_name_textBox.TabIndex = 27;
            // 
            // choose_file_button
            // 
            this.choose_file_button.Location = new System.Drawing.Point(709, 430);
            this.choose_file_button.Name = "choose_file_button";
            this.choose_file_button.Size = new System.Drawing.Size(135, 56);
            this.choose_file_button.TabIndex = 28;
            this.choose_file_button.Text = "Choose file";
            this.choose_file_button.UseVisualStyleBackColor = true;
            this.choose_file_button.Click += new System.EventHandler(this.choose_file_button_Click);
            // 
            // fill_from_file_button
            // 
            this.fill_from_file_button.Location = new System.Drawing.Point(132, 492);
            this.fill_from_file_button.Name = "fill_from_file_button";
            this.fill_from_file_button.Size = new System.Drawing.Size(148, 59);
            this.fill_from_file_button.TabIndex = 29;
            this.fill_from_file_button.Text = "Fill from file";
            this.fill_from_file_button.UseVisualStyleBackColor = true;
            this.fill_from_file_button.Click += new System.EventHandler(this.fill_from_file_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Info file name:";
            // 
            // choose_folder_button
            // 
            this.choose_folder_button.Location = new System.Drawing.Point(724, 13);
            this.choose_folder_button.Name = "choose_folder_button";
            this.choose_folder_button.Size = new System.Drawing.Size(129, 54);
            this.choose_folder_button.TabIndex = 31;
            this.choose_folder_button.Text = "Choose folder";
            this.choose_folder_button.UseVisualStyleBackColor = true;
            this.choose_folder_button.Click += new System.EventHandler(this.choose_folder_button_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.first_last_index_radioButton);
            this.panel5.Controls.Add(this.first_index_radioButton);
            this.panel5.Controls.Add(this.no_index_radioButton);
            this.panel5.Location = new System.Drawing.Point(302, 486);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 73);
            this.panel5.TabIndex = 32;
            // 
            // first_last_index_radioButton
            // 
            this.first_last_index_radioButton.AutoSize = true;
            this.first_last_index_radioButton.Location = new System.Drawing.Point(3, 51);
            this.first_last_index_radioButton.Name = "first_last_index_radioButton";
            this.first_last_index_radioButton.Size = new System.Drawing.Size(123, 17);
            this.first_last_index_radioButton.TabIndex = 2;
            this.first_last_index_radioButton.Text = "First and last indexes";
            this.first_last_index_radioButton.UseVisualStyleBackColor = true;
            // 
            // first_index_radioButton
            // 
            this.first_index_radioButton.AutoSize = true;
            this.first_index_radioButton.Checked = true;
            this.first_index_radioButton.Location = new System.Drawing.Point(4, 27);
            this.first_index_radioButton.Name = "first_index_radioButton";
            this.first_index_radioButton.Size = new System.Drawing.Size(72, 17);
            this.first_index_radioButton.TabIndex = 1;
            this.first_index_radioButton.TabStop = true;
            this.first_index_radioButton.Text = "First index";
            this.first_index_radioButton.UseVisualStyleBackColor = true;
            // 
            // no_index_radioButton
            // 
            this.no_index_radioButton.AutoSize = true;
            this.no_index_radioButton.Location = new System.Drawing.Point(3, 3);
            this.no_index_radioButton.Name = "no_index_radioButton";
            this.no_index_radioButton.Size = new System.Drawing.Size(67, 17);
            this.no_index_radioButton.TabIndex = 0;
            this.no_index_radioButton.Text = "No index";
            this.no_index_radioButton.UseVisualStyleBackColor = true;
            // 
            // fill_track_names_button
            // 
            this.fill_track_names_button.BackColor = System.Drawing.SystemColors.Control;
            this.fill_track_names_button.Location = new System.Drawing.Point(548, 331);
            this.fill_track_names_button.Name = "fill_track_names_button";
            this.fill_track_names_button.Size = new System.Drawing.Size(131, 58);
            this.fill_track_names_button.TabIndex = 33;
            this.fill_track_names_button.Text = "Fill from details title";
            this.fill_track_names_button.UseVisualStyleBackColor = true;
            this.fill_track_names_button.Click += new System.EventHandler(this.fill_track_names_button_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.index_tracks_radioButton);
            this.panel6.Controls.Add(this.no_index_tracks_radioButton);
            this.panel6.Location = new System.Drawing.Point(712, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(163, 55);
            this.panel6.TabIndex = 34;
            // 
            // index_tracks_radioButton
            // 
            this.index_tracks_radioButton.AutoSize = true;
            this.index_tracks_radioButton.Checked = true;
            this.index_tracks_radioButton.Location = new System.Drawing.Point(3, 3);
            this.index_tracks_radioButton.Name = "index_tracks_radioButton";
            this.index_tracks_radioButton.Size = new System.Drawing.Size(51, 17);
            this.index_tracks_radioButton.TabIndex = 1;
            this.index_tracks_radioButton.TabStop = true;
            this.index_tracks_radioButton.Text = "Index";
            this.index_tracks_radioButton.UseVisualStyleBackColor = true;
            // 
            // no_index_tracks_radioButton
            // 
            this.no_index_tracks_radioButton.AutoSize = true;
            this.no_index_tracks_radioButton.Location = new System.Drawing.Point(3, 26);
            this.no_index_tracks_radioButton.Name = "no_index_tracks_radioButton";
            this.no_index_tracks_radioButton.Size = new System.Drawing.Size(67, 17);
            this.no_index_tracks_radioButton.TabIndex = 0;
            this.no_index_tracks_radioButton.Text = "No index";
            this.no_index_tracks_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.delete_start_after_num_textBox);
            this.panel7.Controls.Add(this.delete_after_char_radioButton);
            this.panel7.Controls.Add(this.delete_from_beginning_radioButton);
            this.panel7.Location = new System.Drawing.Point(712, 543);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(127, 46);
            this.panel7.TabIndex = 36;
            // 
            // delete_start_after_num_textBox
            // 
            this.delete_start_after_num_textBox.Location = new System.Drawing.Point(57, 22);
            this.delete_start_after_num_textBox.Name = "delete_start_after_num_textBox";
            this.delete_start_after_num_textBox.Size = new System.Drawing.Size(51, 20);
            this.delete_start_after_num_textBox.TabIndex = 3;
            // 
            // delete_after_char_radioButton
            // 
            this.delete_after_char_radioButton.AutoSize = true;
            this.delete_after_char_radioButton.Location = new System.Drawing.Point(4, 24);
            this.delete_after_char_radioButton.Name = "delete_after_char_radioButton";
            this.delete_after_char_radioButton.Size = new System.Drawing.Size(47, 17);
            this.delete_after_char_radioButton.TabIndex = 1;
            this.delete_after_char_radioButton.Text = "After";
            this.delete_after_char_radioButton.UseVisualStyleBackColor = true;
            // 
            // delete_from_beginning_radioButton
            // 
            this.delete_from_beginning_radioButton.AutoSize = true;
            this.delete_from_beginning_radioButton.Checked = true;
            this.delete_from_beginning_radioButton.Location = new System.Drawing.Point(4, 3);
            this.delete_from_beginning_radioButton.Name = "delete_from_beginning_radioButton";
            this.delete_from_beginning_radioButton.Size = new System.Drawing.Size(115, 17);
            this.delete_from_beginning_radioButton.TabIndex = 0;
            this.delete_from_beginning_radioButton.TabStop = true;
            this.delete_from_beginning_radioButton.Text = "From the beginning";
            this.delete_from_beginning_radioButton.UseVisualStyleBackColor = true;
            // 
            // delete_repeating_start_button
            // 
            this.delete_repeating_start_button.BackColor = System.Drawing.SystemColors.Control;
            this.delete_repeating_start_button.Location = new System.Drawing.Point(548, 537);
            this.delete_repeating_start_button.Name = "delete_repeating_start_button";
            this.delete_repeating_start_button.Size = new System.Drawing.Size(135, 56);
            this.delete_repeating_start_button.TabIndex = 37;
            this.delete_repeating_start_button.Text = "Delete repeating start";
            this.delete_repeating_start_button.UseVisualStyleBackColor = true;
            this.delete_repeating_start_button.Click += new System.EventHandler(this.delete_repeating_start_button_Click);
            // 
            // add_zeros_button
            // 
            this.add_zeros_button.Location = new System.Drawing.Point(317, 375);
            this.add_zeros_button.Name = "add_zeros_button";
            this.add_zeros_button.Size = new System.Drawing.Size(131, 55);
            this.add_zeros_button.TabIndex = 38;
            this.add_zeros_button.Text = "Add zeros to indexes";
            this.add_zeros_button.UseVisualStyleBackColor = true;
            this.add_zeros_button.Click += new System.EventHandler(this.add_zeros_button_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.back_radioButton);
            this.panel8.Controls.Add(this.front_radioButton);
            this.panel8.Location = new System.Drawing.Point(453, 377);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(87, 55);
            this.panel8.TabIndex = 39;
            // 
            // back_radioButton
            // 
            this.back_radioButton.AutoSize = true;
            this.back_radioButton.Location = new System.Drawing.Point(4, 27);
            this.back_radioButton.Name = "back_radioButton";
            this.back_radioButton.Size = new System.Drawing.Size(50, 17);
            this.back_radioButton.TabIndex = 1;
            this.back_radioButton.TabStop = true;
            this.back_radioButton.Text = "Back";
            this.back_radioButton.UseVisualStyleBackColor = true;
            // 
            // front_radioButton
            // 
            this.front_radioButton.AutoSize = true;
            this.front_radioButton.Checked = true;
            this.front_radioButton.Location = new System.Drawing.Point(4, 4);
            this.front_radioButton.Name = "front_radioButton";
            this.front_radioButton.Size = new System.Drawing.Size(49, 17);
            this.front_radioButton.TabIndex = 0;
            this.front_radioButton.TabStop = true;
            this.front_radioButton.Text = "Front";
            this.front_radioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(112, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Input [number] for number, [letter]/[Letter] for letter";
            // 
            // delete_blank_checkBox
            // 
            this.delete_blank_checkBox.AutoSize = true;
            this.delete_blank_checkBox.Checked = true;
            this.delete_blank_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delete_blank_checkBox.Location = new System.Drawing.Point(653, 178);
            this.delete_blank_checkBox.Name = "delete_blank_checkBox";
            this.delete_blank_checkBox.Size = new System.Drawing.Size(91, 17);
            this.delete_blank_checkBox.TabIndex = 41;
            this.delete_blank_checkBox.Text = "Delete blanks";
            this.delete_blank_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 610);
            this.Controls.Add(this.delete_blank_checkBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.add_zeros_button);
            this.Controls.Add(this.delete_repeating_start_button);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.fill_track_names_button);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.choose_folder_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fill_from_file_button);
            this.Controls.Add(this.choose_file_button);
            this.Controls.Add(this.file_name_textBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.between_end_textBox);
            this.Controls.Add(this.between_start_textBox);
            this.Controls.Add(this.replace_between_checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.file_mask_textBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_index_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_text_textBox);
            this.Controls.Add(this.old_text_textBox);
            this.Controls.Add(this.replace_button);
            this.Controls.Add(this.to_lower_case_button);
            this.Controls.Add(this.directory_path_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File renamer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directory_path_textBox;
        private System.Windows.Forms.Button to_lower_case_button;
        private System.Windows.Forms.Button replace_button;
        private System.Windows.Forms.TextBox old_text_textBox;
        private System.Windows.Forms.TextBox new_text_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton first_instance_radioButton;
        private System.Windows.Forms.RadioButton last_instance_radioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton all_instances_radioButton;
        private System.Windows.Forms.Button add_index_button;
        private System.Windows.Forms.RadioButton start_by_name_radioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton end_radioButton;
        private System.Windows.Forms.RadioButton start_by_time_radioButton;
        private System.Windows.Forms.TextBox file_mask_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instance_num_textBox;
        private System.Windows.Forms.RadioButton instance_num_radioButton;
        private System.Windows.Forms.CheckBox replace_between_checkBox;
        private System.Windows.Forms.TextBox between_start_textBox;
        private System.Windows.Forms.TextBox between_end_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton leave_first_letters_radioButton;
        private System.Windows.Forms.RadioButton leave_first_letter_radioButton;
        private System.Windows.Forms.RadioButton everything_radioButton;
        private System.Windows.Forms.CheckBox first_letters_upcase_checkBox;
        private System.Windows.Forms.CheckBox first_letter_upcase_checkBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox delete_num_textBox;
        private System.Windows.Forms.RadioButton end_delete_radioButton;
        private System.Windows.Forms.RadioButton beginning_delete_radioButton;
        private System.Windows.Forms.TextBox file_name_textBox;
        private System.Windows.Forms.Button choose_file_button;
        private System.Windows.Forms.Button fill_from_file_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button choose_folder_button;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton first_last_index_radioButton;
        private System.Windows.Forms.RadioButton first_index_radioButton;
        private System.Windows.Forms.RadioButton no_index_radioButton;
        private System.Windows.Forms.Button fill_track_names_button;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton index_tracks_radioButton;
        private System.Windows.Forms.RadioButton no_index_tracks_radioButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton delete_after_char_radioButton;
        private System.Windows.Forms.RadioButton delete_from_beginning_radioButton;
        private System.Windows.Forms.Button delete_repeating_start_button;
        private System.Windows.Forms.TextBox delete_start_after_num_textBox;
        private System.Windows.Forms.Button add_zeros_button;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton back_radioButton;
        private System.Windows.Forms.RadioButton front_radioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox delete_blank_checkBox;
    }
}


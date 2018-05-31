using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Id3;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replace(string old_text, string new_text, int mode)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                string directory_path = directory_path_textBox.Text;
                string[] fileEntries = Directory.GetFiles(directory_path, file_mask_textBox.Text);
                if (all_instances_radioButton.Checked && old_text == "" && !replace_between_checkBox.Checked)
                {
                    MessageBox.Show("No text to be replaced");
                    return;
                }
                foreach (string fileName in fileEntries)
                {
                    if (mode==1)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (!replace_between_checkBox.Checked)                            
                            file_name = file_name.Replace(old_text, new_text);
                        else
                        {
                            if (between_start_textBox.Text=="" || between_end_textBox.Text=="") {
                                MessageBox.Show("One of the replacement bounds is empty");
                                return;
                            }
                            int between_start, between_end;
                            while ((between_start=file_name.IndexOf(between_start_textBox.Text)) > -1 && (between_end=file_name.IndexOf(between_end_textBox.Text)) > -1)
                                file_name = file_name.Replace(file_name.Substring(between_start, between_end - between_start + 1), new_text_textBox.Text);
                            if (delete_blank_checkBox.Checked)
                                while (file_name.IndexOf("  ")>-1)
                                    file_name = file_name.Replace("  ", " ");
                        }
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                    else if (mode==2)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (!replace_between_checkBox.Checked)
                        {
                            if (old_text == "")
                                file_name = new_text + file_name;
                            else
                            {
                                if (file_name.IndexOf(old_text) != -1)
                                {
                                    file_name = file_name.Insert(file_name.IndexOf(old_text), ";");
                                    file_name = file_name.Replace(";" + old_text, new_text);
                                }
                            }
                        }
                        else
                        {
                            if (between_end_textBox.Text == "")
                            {
                                MessageBox.Show("Right replacement bound is empty");
                                return;
                            }
                            else if (between_start_textBox.Text == "" && file_name.IndexOf(between_end_textBox.Text) > -1)
                            {
                                file_name = file_name.Insert(0, ";");
                                file_name = file_name.Replace(file_name.Substring(0, file_name.IndexOf(between_end_textBox.Text)+1), new_text_textBox.Text);
                                if (delete_blank_checkBox.Checked)
                                    while (file_name.IndexOf("  ") > -1)
                                        file_name = file_name.Replace("  ", " ");
                            }
                            else
                            {
                                int between_start, between_end;
                                if ((between_start = file_name.IndexOf(between_start_textBox.Text)) > -1 && (between_end = file_name.IndexOf(between_end_textBox.Text)) > -1)
                                {
                                    file_name = file_name.Insert(between_start, ";");
                                    file_name = file_name.Replace(file_name.Substring(between_start, between_end - between_start + 2), new_text_textBox.Text);
                                }
                                if (delete_blank_checkBox.Checked)
                                    while (file_name.IndexOf("  ") > -1)
                                        file_name = file_name.Replace("  ", " ");
                            }
                        }
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                    else if (mode==3)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (!replace_between_checkBox.Checked)
                        {
                            if (old_text == "")
                                file_name = file_name + new_text;
                            else
                            {
                                if (file_name.LastIndexOf(old_text) != -1)
                                {
                                    file_name = file_name.Insert(file_name.LastIndexOf(old_text), ";");
                                    file_name = file_name.Replace(";" + old_text, new_text);
                                }
                            }
                        }
                        else
                        {
                            if (between_start_textBox.Text == "")
                            {
                                MessageBox.Show("Left replacement bound is empty");
                                return;
                            }
                            else if (between_end_textBox.Text == "" && file_name.LastIndexOf(between_start_textBox.Text)>-1)
                            {
                                file_name = file_name.Insert(file_name.LastIndexOf(between_start_textBox.Text), ";");
                                file_name = file_name.Replace(file_name.Substring(file_name.LastIndexOf(between_start_textBox.Text)-1), new_text_textBox.Text);
                                if (delete_blank_checkBox.Checked)
                                    while (file_name.IndexOf("  ") > -1)
                                        file_name = file_name.Replace("  ", " ");
                            }
                            else
                            {
                                int between_start, between_end;
                                if ((between_start = file_name.LastIndexOf(between_start_textBox.Text)) > -1 && (between_end = file_name.LastIndexOf(between_end_textBox.Text)) > -1)
                                {
                                    file_name = file_name.Insert(between_start, ";");
                                    file_name = file_name.Replace(file_name.Substring(between_start, between_end - between_start + 2), new_text_textBox.Text);
                                }
                                if (delete_blank_checkBox.Checked)
                                    while (file_name.IndexOf("  ") > -1)
                                        file_name = file_name.Replace("  ", " ");
                            }
                        }
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                    else if (mode==4)
                    {
                        int num;
                        bool c = Int32.TryParse(instance_num_textBox.Text, out num);
                        if (c == false || num<1)
                        {
                            MessageBox.Show("Invalid number");
                            return;
                        }
                        num--;
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (!replace_between_checkBox.Checked)
                        {
                            if (old_text == "")
                                return;
                            else
                            {
                                int found=-1;
                                int i = 0, j;
                                for (j = 0; j < num; j++)
                                {
                                    found = file_name.IndexOf(old_text, i);
                                    if (found >= 0)
                                        i = found+1;
                                    else break;
                                    if (i == file_name.Length)
                                        break;
                                }
                                if (found != -1 && j==num)
                                {
                                    file_name = file_name.Insert(found, ";");
                                    file_name = file_name.Replace(";" + old_text, new_text);
                                }
                            }
                        }
                        else
                        {
                            if (between_start_textBox.Text == "" || between_end_textBox.Text == "")
                            {
                                MessageBox.Show("One of the replacement bounds is empty");
                                return;
                            }                            
                            else
                            {
                                int between_start=-1, between_end=-1;
                                int i = 0, j1, j2;
                                for (j1 = 0; j1 < num; j1++)
                                {
                                    between_start = file_name.IndexOf(between_start_textBox.Text, i);
                                    if (between_start >= 0)
                                        i = between_start+1;
                                    else break;
                                    if (i == file_name.Length)
                                        break;
                                }
                                i = 0;
                                for (j2 = 0; j2 < num; j2++)
                                {
                                    between_end = file_name.IndexOf(between_end_textBox.Text, i);
                                    if (between_end >= 0)
                                        i = between_end+1;
                                    else break;
                                    if (i == file_name.Length)
                                        break;
                                }
                                if (between_start > -1 && between_end > -1 && between_end>between_start && j1==num && j2==num)
                                {
                                    file_name = file_name.Insert(between_start, ";");
                                    file_name = file_name.Replace(file_name.Substring(between_start, between_end - between_start + 2), new_text_textBox.Text);
                                }
                                if (delete_blank_checkBox.Checked)
                                    while (file_name.IndexOf("  ") > -1)
                                        file_name = file_name.Replace("  ", " ");
                            }
                        }
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }
        }

        private void replace_button_Click(object sender, EventArgs e)
        {
            string old_text_temp = old_text_textBox.Text, new_text_temp = new_text_textBox.Text;
            int count_number_old = (old_text_temp.Length-old_text_temp.Replace("[number]", "").Length)/"[number]".Length;
            int count_number_new = (new_text_temp.Length-new_text_temp.Replace("[number]", "").Length)/"[number]".Length;
            int count_letter_old = (old_text_temp.Length-old_text_temp.Replace("[letter]", "").Length)/"[letter]".Length;
            int count_letter_new = (new_text_temp.Length-new_text_temp.Replace("[letter]", "").Length)/"[letter]".Length;
            int count_Letter_old = (old_text_temp.Length-old_text_temp.Replace("[Letter]", "").Length)/"[Letter]".Length;
            int count_Letter_new = (new_text_temp.Length-new_text_temp.Replace("[Letter]", "").Length)/"[letter]".Length;
            bool special_char_new_text = false;
            if (((count_number_new > 0) || (count_letter_new > 0) || (count_Letter_new > 0)) && count_number_old==count_number_new && count_letter_old==count_letter_new && count_Letter_old==count_Letter_new)
                special_char_new_text = true;

            if (((count_number_new > 0) || (count_letter_new > 0) || (count_Letter_new > 0)) && !special_char_new_text)
            {
                MessageBox.Show("Expression for new text doesn't correspond to old text");
                return;
            }
            
            ArrayList new_text_array = new ArrayList();
            string new_text="", new_temp="", new_added="";
            if (special_char_new_text)
                new_text_array.Add(new_text_textBox.Text);

            ArrayList old_text_array = new ArrayList();
            old_text_array.Add(old_text_textBox.Text);
            int num_index;
            if ((num_index=old_text_textBox.Text.IndexOf("[number]")) > -1){
                bool is_still_num = true;
                while (is_still_num)
                {
                    is_still_num = false;
                    for (int i = 0; i < old_text_array.Count; i++ )
                    {
                        string old_text = old_text_array[i].ToString();
                        if (special_char_new_text)
                           new_text = new_text_array[i].ToString();
                        if ((num_index = old_text.IndexOf("[number]")) > -1)
                        {
                            is_still_num = true;
                            old_text_array.Remove(old_text);
                            if (special_char_new_text)
                                new_text_array.Remove(new_text);
                            string temp = old_text.Insert(num_index, ";");
                            if (special_char_new_text)
                                new_temp = new_text.Insert(new_text.IndexOf("[number]"), ";");
                            for (int j = 0; j < 10; j++)
                            {
                                string added = temp.Replace(";[number]", j.ToString());
                                old_text_array.Add(added);
                                if (special_char_new_text) {
                                    new_added = new_temp.Replace(";[number]", j.ToString());
                                    new_text_array.Add(new_added);
                                }
                            }
                        }
                    }
                }

            }
            int letter_index;
            if ((letter_index = old_text_textBox.Text.IndexOf("[letter]")) > -1)
            {
                bool is_still_letter = true;
                while (is_still_letter)
                {
                    is_still_letter = false;
                    for (int i = 0; i < old_text_array.Count; i++)
                    {
                        string old_text = old_text_array[i].ToString();
                        if (special_char_new_text)
                            new_text = new_text_array[i].ToString();
                        if ((letter_index = old_text.IndexOf("[letter]")) > -1)
                        {
                            is_still_letter = true;
                            old_text_array.Remove(old_text);
                            if (special_char_new_text)
                                new_text_array.Remove(new_text);
                            string temp = old_text.Insert(letter_index, ";");
                            if (special_char_new_text)
                                new_temp = new_text.Insert(new_text.IndexOf("[letter]"), ";");
                            for (Char letter = 'a'; letter <= 'z'; letter++)
                            {
                                string added = temp.Replace(";[letter]", letter.ToString());
                                old_text_array.Add(added);
                                if (special_char_new_text)
                                {
                                    new_added = new_temp.Replace(";[letter]", letter.ToString());
                                    new_text_array.Add(new_added);
                                }
                            }
                        }
                    }
                }
            }
            if ((letter_index = old_text_textBox.Text.IndexOf("[Letter]")) > -1)
            {
                bool is_still_letter = true;
                while (is_still_letter)
                {
                    is_still_letter = false;
                    for (int i = 0; i < old_text_array.Count; i++)
                    {
                        string old_text = old_text_array[i].ToString();
                        if (special_char_new_text)
                            new_text = new_text_array[i].ToString();
                        if ((letter_index = old_text.IndexOf("[Letter]")) > -1)
                        {
                            is_still_letter = true;
                            old_text_array.Remove(old_text);
                            if (special_char_new_text)
                                new_text_array.Remove(new_text);
                            string temp = old_text.Insert(letter_index, ";");
                            if (special_char_new_text)
                                new_temp = new_text.Insert(new_text.IndexOf("[Letter]"), ";");
                            for (Char letter = 'A'; letter <= 'Z'; letter++)
                            {
                                string added = temp.Replace(";[Letter]", letter.ToString());
                                old_text_array.Add(added);
                                if (special_char_new_text)
                                {
                                    new_added = new_temp.Replace(";[Letter]", letter.ToString());
                                    new_text_array.Add(new_added);
                                }
                            }                            
                        }
                    }
                }

            }

            int mode=0;
            if (all_instances_radioButton.Checked)
                mode = 1;
            else if (first_instance_radioButton.Checked)
                mode = 2;
            else if (last_instance_radioButton.Checked)
                mode = 3;
            else if (instance_num_radioButton.Checked)
                mode = 4;

            if (!special_char_new_text)
                foreach (string old_text in old_text_array)
                    replace(old_text, new_text_textBox.Text, mode);
            else
            {
                for (int i=0; i<old_text_array.Count; i++)
                    replace(old_text_array[i].ToString(), new_text_array[i].ToString(), mode);
            }

            if (!replace_between_checkBox.Checked && delete_blank_checkBox.Checked)
            {
                replace("  ", " ", 1);
            }
        }

        private void to_lower_case_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                string directory_path = directory_path_textBox.Text;
                string[] fileEntries = Directory.GetFiles(directory_path, file_mask_textBox.Text);
                foreach (string fileName in fileEntries)
                {
                    if (everything_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "").ToLower();
                        File.Move(fileName, directory_path + "\\" + file_name + " " + extension);
                        File.Move(directory_path + "\\" + file_name + " " + extension, directory_path + "\\" + file_name + extension);
                    }
                    else if (leave_first_letter_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");

                        int index = 0;
                        while (!Char.IsLetter(file_name[index]))
                            index++;

                        Char first_ch = file_name[index];
                        string first_part = "";
                        if (index > 0)
                        {
                            first_part = file_name.Substring(0, index).ToLower();
                        }

                        string second_part = file_name.Substring(index + 1).ToLower();
                        if (first_letter_upcase_checkBox.Checked)
                            first_ch = Char.ToUpper(first_ch);
                        file_name = first_part + first_ch.ToString() + second_part;

                        File.Move(fileName, directory_path + "\\" + file_name + " " + extension);
                        File.Move(directory_path + "\\" + file_name + " " + extension, directory_path + "\\" + file_name + extension);
                    }
                    else if (leave_first_letters_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");

                        string[] words = file_name.Split(new Char[] { ' ', ',', '.', ';', '\t' , '('});
                        foreach (string word in words)
                        {
                            if (word.Length >= 1)
                            {
                                string new_word = word;
                                Char first_ch = new_word[0];
                                new_word = new_word.Substring(1).ToLower();
                                if(first_letters_upcase_checkBox.Checked)
                                    first_ch = Char.ToUpper(first_ch);
                                new_word = first_ch.ToString() + new_word;
                                file_name = file_name.Replace(word, new_word);
                            }
                        }

                        File.Move(fileName, directory_path + "\\" + file_name + " " + extension);
                        File.Move(directory_path + "\\" + file_name + " " + extension, directory_path + "\\" + file_name + extension);
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }  
        }

        private void add_index_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                if (start_by_name_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    int i = 1;
                    foreach (FileInfo fileDir in DefaultFiles)
                    {
                        string file_name = fileDir.FullName;
                        file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");

                        string prefix = "";
                        switch (DefaultFiles.Length.ToString().Length)
                        {
                            case 1:
                            case 2:
                                prefix = (i < 10) ? "0" + i.ToString() : i.ToString();
                                break;
                            case 3:
                                prefix = (i < 10) ? "00" + i.ToString() : ((i < 100) ? "0" + i.ToString() : i.ToString());
                                break;
                            case 4:
                                prefix = (i < 10) ? "000" + i.ToString() : ((i < 100) ? "00" + i.ToString() : ((i < 1000) ? "0" + i.ToString() : i.ToString()));
                                break;
                        }
                        file_name = prefix + " " + file_name;

                        File.Move(fileDir.FullName, directory_path_textBox.Text + "\\" + file_name);
                        i++;
                    }
                }
                else if (start_by_time_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.CreationTime select file).ToArray();

                    int i = 1;
                    foreach (FileInfo fileDir in DefaultFiles)
                    {
                       string file_name=fileDir.FullName;
                       file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");
                       
                       string prefix="";
                       switch (DefaultFiles.Length.ToString().Length) {
                        case 1: case 2:
                            prefix = (i < 10) ? "0" + i.ToString() : i.ToString();
                            break;
                        case 3:
                            prefix = (i < 10) ? "00" + i.ToString() : ((i < 100) ? "0" + i.ToString() : i.ToString());
                            break;
                        case 4:
                            prefix = (i < 10) ? "000" + i.ToString() : ((i < 100) ? "00" + i.ToString() : ((i < 1000) ? "0" + i.ToString() : i.ToString()));
                            break;
                       }
                       file_name = prefix + " " + file_name;

                      File.Move(fileDir.FullName, directory_path_textBox.Text + "\\" + file_name);
                      i++;
                    }
                }
                else if (end_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    int i = 1;
                    foreach (FileInfo fileDir in DefaultFiles)
                    {
                        string file_name = fileDir.FullName;
                        file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");

                        string prefix = "";
                        switch (DefaultFiles.Length.ToString().Length)
                        {
                            case 1:
                            case 2:
                                prefix = (i < 10) ? "0" + i.ToString() : i.ToString();
                                break;
                            case 3:
                                prefix = (i < 10) ? "00" + i.ToString() : ((i < 100) ? "0" + i.ToString() : i.ToString());
                                break;
                            case 4:
                                prefix = (i < 10) ? "000" + i.ToString() : ((i < 100) ? "00" + i.ToString() : ((i < 1000) ? "0" + i.ToString() : i.ToString()));
                                break;
                        }
                        file_name = file_name + " " + prefix + extension;

                        File.Move(fileDir.FullName, directory_path_textBox.Text + "\\" + file_name);
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }  
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                string directory_path = directory_path_textBox.Text;
                string[] fileEntries = Directory.GetFiles(directory_path, file_mask_textBox.Text);
                int num;
                bool c = Int32.TryParse(delete_num_textBox.Text, out num);
                if (c == false || num<0)
                {
                    MessageBox.Show("Invalid number");
                    return;
                }
                foreach (string fileName in fileEntries)
                {
                    if (beginning_delete_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (num<= file_name.Length)
                            file_name = file_name.Substring(num);
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                    else if (end_delete_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        if (num <= file_name.Length)
                        {
                            file_name = file_name.Substring(0, file_name.Length - num - 1);
                            File.Move(fileName, directory_path + "\\" + file_name + extension);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }        
        }

        private void choose_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Text files (*.txt)|*.txt";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {                
                string current_file = OpenFile.FileName;
                file_name_textBox.Text = current_file;
            }

        }

        private void choose_folder_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenFolder = new FolderBrowserDialog();
            OpenFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            if (OpenFolder.ShowDialog() == DialogResult.OK)
            {
                directory_path_textBox.Text = OpenFolder.SelectedPath;
            }
        }

        private void fill_from_file_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_name_textBox.Text))
            {
                if (no_index_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    System.IO.StreamReader tracks_file = new System.IO.StreamReader(file_name_textBox.Text);

                    for (int i = 0; i < DefaultFiles.Length; i++)
                    {
                        string file_name = DefaultFiles[i].FullName;
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = tracks_file.ReadLine();

                        file_name = file_name.Replace("\"", "");
                        file_name = file_name.Replace(":", "-");
                        file_name = file_name.Replace("\\", "-");
                        file_name = file_name.Replace("/", "-");
                        file_name = file_name.Replace("?", "");

                        file_name = directory_path_textBox.Text + "\\" + file_name;
                        if (file_name.Length>256-extension.Length)
                            file_name = file_name.Substring(0, 256 - extension.Length);

                        File.Move(DefaultFiles[i].FullName, file_name + extension);
                    }
                    tracks_file.Close();
                }
                else if (first_index_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    System.IO.StreamReader tracks_file = new System.IO.StreamReader(file_name_textBox.Text);

                    for (int i = 0; i < DefaultFiles.Length; i++)
                    {
                        string file_name = DefaultFiles[i].FullName;
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = tracks_file.ReadLine();

                        string prefix = "";
                        switch (DefaultFiles.Length.ToString().Length)
                        {
                            case 1:
                            case 2:
                                prefix = (i + 1 < 10) ? "0" + (i + 1).ToString() : (i + 1).ToString();
                                break;
                            case 3:
                                prefix = (i + 1 < 10) ? "00" + (i + 1).ToString() : ((i + 1 < 100) ? "0" + (i + 1).ToString() : (i + 1).ToString());
                                break;
                            case 4:
                                prefix = (i + 1 < 10) ? "000" + (i + 1).ToString() : (((i + 1) < 100) ? "00" + (i + 1).ToString() : (((i + 1) < 1000) ? "0" + (i + 1).ToString() : (i + 1).ToString()));
                                break;
                        }
                        file_name = prefix + " " + file_name;

                        file_name = file_name.Replace("\"", "");
                        file_name = file_name.Replace(":", "-");
                        file_name = file_name.Replace("\\", "-");
                        file_name = file_name.Replace("/", "-");
                        file_name = file_name.Replace("?", "");

                        file_name = directory_path_textBox.Text + "\\" + file_name;
                        if (file_name.Length > 256 - extension.Length)
                            file_name = file_name.Substring(0, 256 - extension.Length);

                        File.Move(DefaultFiles[i].FullName, file_name + extension);
                    }
                    tracks_file.Close();
                }
                else if (first_last_index_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    System.IO.StreamReader tracks_file = new System.IO.StreamReader(file_name_textBox.Text);

                    for (int i = 0; i < DefaultFiles.Length; i++)
                    {
                        string file_name = DefaultFiles[i].FullName;
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = tracks_file.ReadLine();

                        string prefix = "";
                        switch (DefaultFiles.Length.ToString().Length)
                        {
                            case 1:
                            case 2:
                                prefix = (i + 1 < 10) ? "0" + (i + 1).ToString() : (i + 1).ToString();
                                break;
                            case 3:
                                prefix = (i + 1 < 10) ? "00" + (i + 1).ToString() : ((i + 1 < 100) ? "0" + (i + 1).ToString() : (i + 1).ToString());
                                break;
                            case 4:
                                prefix = (i + 1 < 10) ? "000" + (i + 1).ToString() : (((i + 1) < 100) ? "00" + (i + 1).ToString() : (((i + 1) < 1000) ? "0" + (i + 1).ToString() : (i + 1).ToString()));
                                break;
                        }
                        file_name = prefix + " " + file_name + " " + prefix;

                        file_name = file_name.Replace("\"", "");
                        file_name = file_name.Replace(":", "-");
                        file_name = file_name.Replace("\\", "-");
                        file_name = file_name.Replace("/", "-");
                        file_name = file_name.Replace("?", "");

                        file_name=directory_path_textBox.Text + "\\" + file_name;
                        if (file_name.Length > 256 - extension.Length)
                            file_name = file_name.Substring(0, 256 - extension.Length);

                        File.Move(DefaultFiles[i].FullName, file_name + extension);
                    }
                    tracks_file.Close();
                }
            }

        }

        private void fill_track_names_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                if (index_tracks_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles("*.mp3");
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    int i = 1;
                    foreach (FileInfo fileDir in DefaultFiles)
                    {
                        string file_name=null;
                        using (var mp3 = new Mp3File(fileDir.FullName))
                        {
                            Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2x);
                            if (tag != null) 
                                file_name = tag.Title.Value;
                        }

                        if (file_name!=null) {
                            file_name = file_name.Replace("\0", "");
                            file_name = file_name.Replace("\"", "");
                            file_name = file_name.Replace(":", "-");
                            file_name = file_name.Replace("\\", "-");
                            file_name = file_name.Replace("/", "-");
                            file_name = file_name.Replace("?", "");

                            string prefix = "";
                            switch (DefaultFiles.Length.ToString().Length)
                            {
                                case 1:
                                case 2:
                                    prefix = (i < 10) ? "0" + i.ToString() : i.ToString();
                                    break;
                                case 3:
                                    prefix = (i < 10) ? "00" + i.ToString() : ((i < 100) ? "0" + i.ToString() : i.ToString());
                                    break;
                                case 4:
                                    prefix = (i < 10) ? "000" + i.ToString() : ((i < 100) ? "00" + i.ToString() : ((i < 1000) ? "0" + i.ToString() : i.ToString()));
                                    break;
                            }
                            file_name = prefix + " " + file_name;
                            if (delete_blank_checkBox.Checked)
                                while (file_name.IndexOf("  ") > -1)
                                    file_name = file_name.Replace("  ", " ");

                            file_name = directory_path_textBox.Text + "\\" + file_name;
                            if (file_name.Length > 252)
                                file_name = file_name.Substring(0, 252);

                            File.Move(DefaultFiles[i].FullName, file_name + ".mp3");

                            File.Move(fileDir.FullName, file_name);
                        }

                        i++;
                    }
                }
                else if (no_index_tracks_radioButton.Checked)
                {
                    DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                    FileInfo[] orig = dirMail.GetFiles("*.mp3");
                    FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                    int i = 1;
                    foreach (FileInfo fileDir in DefaultFiles)
                    {
                        string file_name=null;
                        using (var mp3 = new Mp3File(fileDir.FullName))
                        {
                            Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2x);
                            if (tag!=null)
                                file_name = tag.Title.Value;
                        }

                        if (file_name != null)
                        {
                            file_name = file_name.Replace("\0", "");
                            file_name = file_name.Replace("\"", "");
                            file_name = file_name.Replace(":", "-");
                            file_name = file_name.Replace("\\", "-");
                            file_name = file_name.Replace("/", "-");
                            file_name = file_name.Replace("?", "");

                            if (delete_blank_checkBox.Checked)
                                while (file_name.IndexOf("  ") > -1)
                                    file_name = file_name.Replace("  ", " ");

                            file_name = directory_path_textBox.Text + "\\" + file_name;
                            if (file_name.Length > 252)
                                file_name = file_name.Substring(0, 252);

                            File.Move(fileDir.FullName, file_name + ".mp3");
                        }
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }
        }

        private void delete_repeating_start_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                DirectoryInfo dirMail = new DirectoryInfo(directory_path_textBox.Text);
                FileInfo[] orig = dirMail.GetFiles(file_mask_textBox.Text);
                FileInfo[] DefaultFiles = (from file in orig orderby file.FullName select file).ToArray();

                string file_name = DefaultFiles[0].FullName;
                file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");
                string prev_file_name = file_name;

                if (delete_from_beginning_radioButton.Checked)
                  for (int i = 1; i < DefaultFiles.Length; i++)
                  {
                      file_name = DefaultFiles[i].FullName;
                      file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");
                      string temp = file_name;
                      
                      if (file_name.Substring(0, 4) == prev_file_name.Substring(0, 4))
                      {
                          int j = 3;
                          int k = 3;
                          while ((j < file_name.Length) && (file_name.Substring(0, j) == prev_file_name.Substring(0, j)))
                          {
                              if (file_name[j] == ' ')
                                  k = j;
                              j++;
                          }
                          if (!(j == file_name.Length || (j - 1) == file_name.LastIndexOf(".")))
                            file_name = file_name.Substring(k + 1);
                      }                   
                      
                      prev_file_name = temp;
                      
                      File.Move(DefaultFiles[i].FullName, directory_path_textBox.Text + "\\" + file_name);
                  }
                else if (delete_after_char_radioButton.Checked)
                {
                    int num;
                    bool c = Int32.TryParse(delete_start_after_num_textBox.Text, out num);
                    if (c == false || num < 0)
                    {
                        MessageBox.Show("Invalid number");
                        return;
                    }
                    for (int i = 1; i < DefaultFiles.Length; i++)
                    {
                        file_name = DefaultFiles[i].FullName;
                        file_name = file_name.Replace(directory_path_textBox.Text + "\\", "");
                        string temp = file_name;                        
                                                
                        if (file_name.Substring(num, 4) == prev_file_name.Substring(num, 4))
                        {
                            int j = num + 3;
                            int k = num + 3;
                            while ((j < file_name.Length) && (file_name.Substring(num, j-num+1) == prev_file_name.Substring(num, j-num+1)))
                            {
                                if (file_name[j] == ' ')
                                    k = j;
                                j++;
                            }
                            if (!(j == file_name.Length || (j - 1) == file_name.LastIndexOf(".")))
                              file_name = file_name.Substring(0, num) + file_name.Substring(k + 1);
                        }

                        prev_file_name = temp;
                        
                        File.Move(DefaultFiles[i].FullName, directory_path_textBox.Text + "\\" + file_name);
                    }                    
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }  
        }

        private void add_zeros_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directory_path_textBox.Text))
            {
                string directory_path = directory_path_textBox.Text;
                string[] fileEntries = Directory.GetFiles(directory_path, file_mask_textBox.Text);
                int num = fileEntries.Length.ToString().Length;
                if (num==1)
                    num=2;
                foreach (string fileName in fileEntries)
                {
                    if (front_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        for (int i=0; i<num-1; i++)
                            if (!Char.IsDigit(file_name, num-1))
                                file_name = file_name.Insert(0, "0");
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                    else if (back_radioButton.Checked)
                    {
                        string file_name = fileName.Replace(directory_path + "\\", "");
                        int extens_point = file_name.LastIndexOf('.');
                        string extension = file_name.Substring(extens_point);
                        file_name = file_name.Replace(extension, "");
                        for (int i = 0; i < num - 1; i++)
                            if (!Char.IsDigit(file_name, file_name.Length - num))
                                file_name = file_name.Insert(file_name.Length - i - 1, "0");
                        File.Move(fileName, directory_path + "\\" + file_name + extension);
                    }
                }
            }
            else
            {
                MessageBox.Show("{0} is not a valid file or directory.", directory_path_textBox.Text);
            }     
        }
    }
}

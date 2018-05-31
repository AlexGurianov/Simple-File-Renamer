# Simple File Renamer
A simple to use Windows program to rename files in a folder automatically according to a specified pattern or in other ways.

The FileRenamer's interface is pretty straightforward.

<p align="center">
<img src="https://drive.google.com/uc?export=view&id=1rgFfgnse5Ow1mZt9iSWNM_c7QoENa-A3" width=80% alt="interface">
</p>

The field "Folder path" is for the folder containing the files. You can optionally specify a pattern in the "File mask" field to process ony the files that match.

The fields "Old text" and "New text" specify the original substring in file name and a substring that it needs to be replaced with. Radio buttons on the right control whether only the first, only the last, the particular one or all occurances of the substring should be replaced.

Mind that leaving the "Old text" empty and
- picking "First instance" will append text to the beginning of each file name;
- picking "Last instance" will append text to the end of each file name.

Alternatively instead of specifying "Old text" you can replace any text between specified substrings by checking the checkbox below. Again mind that:
- leaving left bounding substring empty and picking "First instance" will replace any text from the beginning of file name to the right bounding substring.
- leaving right bounding substring empty and picking "Last instance" will replace any text after left bounding substring to the end of file name.

FileRenamer has some functionality to deal with numbers and letters using wildcards. [letter] and [Letter] match any lowercase and uppercase letter respectively and [number] matches any decimal digit. Moreover, you can use the character matched by the wildcard in "New text". For example, the following setup

<p align="center">
<img src="https://drive.google.com/uc?export=view&id=1NZuCCMVwO3yxfJ4mt4TY-aBg7_cwZnRz" width=60% alt="wildcard example">
</p>

will change "13 old.txt" to "3 new.text" and "17 old.txt" to "7 new.txt".

Checked checkbox "Delete blanks" ensures that the resulting names contain to consecutive space characters.

Additionaly you can:
- delete certain number of characters at the beginning or at the end of the file name;
- index files alphabetically or date created adding the index in the form "01 " at the beginning of at the end of a file name;
- convert all words to lowercase, convert all words to lowercase but leave the first letter of the file name as is (or make it uppercase), convert all words to lowercase but leave the first letters of each word as is (or make them uppercase);
- add zeroes to indexes, i.e. 1 --> 01, at the beginning or at the end of the file name;
- take the file name from title property of the file.

There is also an option to delete repetitive starting words in a sequence of file names, analazyng the names from the beginning or after a certain number of characters. For example 

<p align="center">
<img src="https://drive.google.com/uc?export=view&id=1PU20g6gzjSUz-8PIAHKykYL5UPwD-E5q" width=80% alt="repeating start example">
</p>

Finally you can change the names of N alphabetically ordered files to the N corresponding lines from a specified file, optionally adding to names from the file the first or both indexes.

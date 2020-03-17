# FormTestFileReader
Plan files format generator

The purpose of this application is generate plain files from a specific format.
The formats are created by the user in the application setting each column of the file.
You can also load the data in each column and export it as a plain text file.

By using serialization you can save the progress of your created formats, so you didn't lose them when you close the application.

## FORMATS
You can add a new format by menu __File->New Format...__ or shortcut __Ctrl + N__
Each format needs the following information:
  + Name of the format
  + Name of the file to generate

## STRUCTURES
You can add a new structure to the current format by menu __File->New Structure...__ or shortcut __Ctrl + T__
Each structure needs the following information:
  + Name of the structure
  + Type of the structure (Header, Detail, Footer)

## SETTING THE STRUCTURE
Once you have created the structure, you have to load the columns to fill with data.
By selecting the structure, you can find the "Add Column" panel, where you can add each column for the file structure.
Each column needs at least a name for be loaded to the DataGridView.
Later, you can add a row and complete the date for the file.

## EXPORTING THE FILE
By menu __File-> Export to file...__ or shortcut __Ctrl + Alt + S__ you can export the current format to a file.
The filename will be the one you set at the format creation menu.
It will show a FolderBrowserDialog to select the saving path for the file.

## SERIALIZATION
In background, it'll be serializing the created formats in a _Binary, SOAP or XML_ file.
You can activate and select the serialization mode in the _Preferences Menu_.

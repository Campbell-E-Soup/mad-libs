# Madlibs App
Made for CITC-2335
### Table of Contents
- [Documentation](#documentation)
  - [For Users](#for-users)
  - [For Devs](#for-devs)
- [Credits](#credits)

## Documentation

### For Users
<details open>

<summary>Information on how to use the app.</summary>

#### How to use the app
![MadLibs Main](https://github.com/user-attachments/assets/d46ab25f-627b-4d34-bd5b-fbbb0caa5796)<br/>
This is the Main Menu of the Mad Libs App!<br/>
From here you have the option to select a tag and randomly choose a prompt containing that tag, or directly selecting a prompt from a text file by selecting the "..." button.<br/>
Furthermore, you can create a new MadLib with the Create Button!<br/>

![MadLibs Create](https://github.com/user-attachments/assets/aed7a3b8-3090-4e72-89dc-07c786b2e0b6)<br/>
Here you are prompted to begin writing your own custom MadLib!<br/>
The buttons on the side cover common blank terms to place within your MadLib (these are the words users will be prompted to enter as they play the MadLib).<br/>

![MadLibs Create Dropdown](https://github.com/user-attachments/assets/9da6add9-345e-4f0c-b77e-e8af86294da2)<br/>
Additonally more obscure blank terms can be selected from the dropdown menu.<br/>
Include Tags to add your MadLibn into your personal Library and it may be selected when a relevant tag is selected
Closing the Create menu returns you to the Main Menu.<br/>

![MadLibs Main test](https://github.com/user-attachments/assets/be0a0c84-a711-4d0e-abaf-cf1945b5955e)<br/>
Lets try playing our test MadLib!<br/>

![MadLibs Play](https://github.com/user-attachments/assets/0ea2e219-6499-414f-b610-66fc1b46d62e)<br/>
After pressing Play, the user will be continually prompted to fill in the blanks for the MadLib, and preset the user with examples for each blank.<br/>

![MadLibs Story](https://github.com/user-attachments/assets/1fb66edc-2724-49b6-975c-169d2ce285b1)<br/>
After Completing your prompts you will be brought to the Story menu and your final Story will be visible!<br/>
You can download the final story as a text file with the Download button, or copy the story to your Clipboard with the Copy button.<br/>
Whenever you are finished looking at your Story, you can return to the Main Menu with the Exit button.<br/>
</details>

### For Devs
<details open>

<summary>Information on the project's classes</summary>

### Word.cs
The object that [MadLib.cs](#madlibcs) uses to store information for blank spaces.<br/><br/>

**Constructors:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| static Word() | This static constructor initializes the static Examples and ExtendType dictionaries when the class is first loaded. |
| public Word(string replace, string type) | This constructor initializes a new instance of the 'Word' class, setting the 'Replace' and 'Type' properties with the provided values. |

**Properties:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public string Replace { get; set; } | The word to replace the blank with. |
| public string Type { get; set; } | The type of word (noun, adjective, etc.) |
| public static Dictionary<string, string> Examples { get; set; } | A static dictionary containing examples of valid word types, used to determine which type of word should be replaced in [MadLib.cs](#madlibcs). |
| private static Dictionary<string, string> ExtendType { get; set; } | A static dictionary that provides more readable descriptions of word types (e.g., "adjective" for "adj"). |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public string GetPrompt() | Generates a user prompt based on the word type, in plain English. If the word type has an extended description in ExtendType, it uses that; otherwise, it uses the original type. |
| private bool isVowel(char c) | Helper method that checks if a given character is a vowel (used in 'GetPrompt()' to decide whether to use "a" or "an"). |

### Story.cs
It processes a line of text to extract tags and stores the remaining text as a story template.<br/><br/>

**Constructors:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public Story(string line) | Creates a new Story object. It looks for tags (inside {}), saves them in the Tags list, and removes them from the story text. This text is saved in the Str property. |

**Properties:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public List<string> Tags { get; set; } | A list that stores all the tags extracted from the story text. |
| public string Str { get; set; }| The story text with the tags removed. |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public override string ToString() | Creates a readable string that lists the tags and the story template. Useful for debugging or displaying the data. |

### StoryList.cs
It handles a collection of Story objects, it populates and displays them.<br/><br/>

**Constructors:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public StoryList() | Initializes the Stories list. |
| public StoryList(string path) | Initializes the Stories list using a file path to specify a file containing the story data. |

**Properties:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public List<[Story](#storycs)> Stories { get; set; } | A list that stores Story objects. Holds all the stories created from the source. Can be used to retrieve or modify the list of stories in the StoryList. |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public override string ToString() | Combines all stories in the list into one string. Each story is added on a new line to make it easier to read. |

### MadLib.cs
Generates a list of words to be replaced in story. Each blank space is represented by a key in [Word.cs's](#wordcs) Example dictionary, surrounded by brackets [ ].<br/><br/>

**Constructors:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public MadLib(string str) | Initializes a MadLib object with 'Story' equal to 'str.' |

**Properties:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public List\<[Word](#wordcs)\> WordList { get; set; } | A list of [Words](#wordcs) for each valid key to be replaced in the 'Story' property. |
| private string Story { get; set; } | A string that contains keys to be replaced. |
| public string FinishedStory { get; set; } | 'Story' with all the keys replaced. |
| private int index { get; set; } | The current position in 'WordList' to be replaced. |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public void Load() | Generates the 'WordList' for each key in 'Story.' |
| public Word Next() | Returns the next [Word](#wordcs) in 'WordList.' Returns null at the end of the list. |
| public void Finish() | Replaces each blank space for each [Word](#wordcs) in 'WordList.' |

### IOSystem.cs
This class is used for reading and writing stories to a text file.<br/><br/>

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public static string GetFirstString() | Returns the first line of 'default.txt' from the 'Text Files' folder. |
| public static string GetFirstString(string filePath) | Returns the first line of the text file at the specified path. |
| public static List<string> GetAllStrings() | Returns each line from 'default.txt' as a list of strings. |
| public static List<string> GetAllStrings(string filePath) | Returns each line from the text file at the specified path as a list of strings. |
| public static bool AppendToFile(string filePath, string appendLine) | Appends the string to the end of the text file at the specified path, returns true if saved successfully. |
| public static bool AppendListToFile(string filePath, List<string> appendList) | Appends the list of string to the end of the text file at the specified path, returns true if saved successfully. |
</details>

## Credits

### Created by:

[alexpop80](https://github.com/alexpop80)<br/>
[Campbell-E-Soup](https://github.com/Campbell-E-Soup)<br/>
[cprine](https://github.com/cprine)<br/>
[HarvestMint](https://github.com/HarvestMint)<br/>
[JudyChavez](https://github.com/JudyChavez)<br/>
[MorganRLowe](https://github.com/MorganRLowe)

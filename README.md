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
**This still needs to be done**<br/>This should have screenshots <br/> and information on how to do stuff!
</details>

### For Devs
<details open>

<summary>Information on the project's classes</summary>

### Word.cs
The object that [Madlibs.cs](#madlibscs) uses to store information for blank spaces.<br/><br/>

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
| public static Dictionary<string, string> Examples { get; set; } | A static dictionary containing examples of valid word types, used to determine which type of word should be replaced in [Madlibs.cs](#madlibscs). |
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
| public string Str { get; set; } = string.Empty; | The story text with the tags removed. |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public override string ToString() | Creates a readable string that lists the tags and the story template. Useful for debugging or displaying the data. |

### Storylist.cs
It handles a collection of Story objects, it populates and displays them.<br/><br/>

**Constructors:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public StoryList() | Initializes the Stories list. |
| public StoryList(string path) | Initializes the Stories list using a file path to specify a file containing the story data. |

**Properties:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public List<Story> Stories { get; set; } | A list that stores Story objects. Holds all the stories created from the source. Can be used to retrieve or modify the list of stories in the StoryList. |

**Methods:**<br/>
| Declaration | Description |
| ----------- | ----------- |
| public override string ToString() | Combines all stories in the list into one string. Each story is added on a new line to make it easier to read. |

**The rest of the classes need to be finished**

### Madlibs.cs

### IOSystem.cs

</details>

## Credits

To be added

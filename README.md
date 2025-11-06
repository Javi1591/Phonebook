# Assignment 4 – Phone Book Application (C#)

A C# console application that demonstrates **exception handling**, **file I/O**, and **menu-driven interaction**.  
This project expands on previous assignments by using persistent data storage in a text file and structured program flow with error handling.

---

## Description
The Phone Book application lets users add and view contact information that is saved to a local text file (`phonebook.txt`).  
It uses a menu system with numbered options and a sentinel value (`-1`) to exit the loop.  
Each contact entry is stored as a line containing a name and a phone number separated by a tab.

---

## Features
- Menu-driven interface with three options:
  1. Add New Contact  
  2. View All Contacts  
  -1. Exit
- Creates and appends to `phonebook.txt` in the program directory.
- Reads and displays stored contacts with a formatted header.
- Implements **exception handling** (`try` / `catch`) to prevent runtime crashes.
- Uses the `StreamWriter` and `StreamReader` classes for text-file manipulation.

---

## Core Logic
1. Display a main menu inside a `do … while` loop.  
2. Read user input and convert it to an integer.  
3. Process the selection using a `switch` statement:
   - **Case 1:** call `AddContact(filePath)` to write a new entry.  
   - **Case 2:** call `ViewContacts(filePath)` to read and display all contacts.  
   - **Case -1:** exit the loop.  
4. Validate invalid entries with a default message.  
5. Wrap file operations in `try` / `catch` blocks to handle I/O exceptions safely.

---

## Input Validation
- Ensures numeric menu choices.  
- Provides fallback messages for invalid or missing inputs.  
- Uses the sentinel value (`-1`) to terminate execution gracefully.

---

## Build & Run

### Requirements
- .NET 6.0 SDK or newer  

### Execution
From Visual Studio or a terminal:
```bash
dotnet run

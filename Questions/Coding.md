# InClass2 - Classes, Objects, and File I/O

## Coding Problem

## Overview

Your task is to demonstrate the ability to read a csv file consisting of Author records, create individual Author instances, add them to a composite class and output the composite class to a JSON file.

A console application has been provided and is in the `AssessmentSolution` folder.

### General Validation Rules

All validation is to be performed by throwing exceptions. Here are some general requirements.

- Exceptions must have meaningful error messages.
- Error messages must include details about the limits for acceptable values.
- class must throw exceptions.
- All string information must contain text. Null, empty, and plain white-space text is not allowed. Sanitize your strings by trimming the leading and trailing whitespace.
- All number information must be > 0.

## Author class: Parse/TryParse

Add 2 methods to the Author class. These methods will receive a string consisting of comma separated values. The string represents a single instance of a Author. The given Author class code is valid and does not need to be altered.

The Parse method will break the string apart and return an instance of Author. 

The TryParse method will receive a string representing an instance of Author. The method will return a boolean value indicating a successful creation of a Author instance. The Method out parameter will return the Author instance of the parsed string.

## Publication class: Complete AddAuthor(Author author)

Add code to the supplied AddAuthor(Author author) method to check that `a)` the parameter has a value and `b)` the author does not already exist on the list of authors of the Reading for the Publication. The author and contact url combination must be unique. Example: `Bob Smith` at `bsmith@hotmail.ca` is different than `Bob Smith` at `smithb@yahoo.com`; `Bob Smith` at `thesmiths@google.mail.ca` is different than `Pat Smith` at `thesmiths@google.mail.ca`. If the author passes both validations, add to the list of authors.

## Program.cs: Read a csv file.

Create code that will read a unknown set of csv records from a file. Each record represents data about a single author. The file name will be Data.dat. The file is located in your source folder.

## Program.cs: CSV to Author Instance

Write code that will take the set of inputted csv records, create a author instance for each record using your `Author.TryParse()`. Add the returned Author instance to the existing Publication.

## Program.cs: Output your data to a JSON file.

Write code that will output your Publication instance to a JSON file. Include the following options for your json file: `WriteIndented` and `IncludeFields`. Use your firstname (xxxx) in naming the JSON file: `xxxx_Publication.json`.
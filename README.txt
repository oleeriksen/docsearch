Version 1: 11-1-2024

A seachengine that consist of an indexer and a search program.

The indexer will crawl a folder (in depth) and create a reverse index
in a database. It will only index all text files with .txt as extension.

The search program is a console program that offers a query-based search
in the reverse index. It is in the ConsoleSearch project.

The class library Shared contains types that are used by the indexer
and the ConsoleSearch. It contains:

- paths.cs that contains a path for files to index and a path for
  the database
- a type for a document (BEDocument (BE for Business Entity))

The project Renamer is a console program used to rename all files in a
folder. Current version will rename all files with no extension to have
.txt as extension.



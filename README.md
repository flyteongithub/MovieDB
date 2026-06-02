# MovieDB

A small Windows Forms application for cataloguing a personal movie collection.
Built on .NET 8 with a Microsoft Access (`.accdb`) database accessed through
OLE DB.

## Features

- Browse the movie library in a `DataGridView`.
- Add new entries with title, director, genre, year, age rating, duration,
  user rating and a free-form summary.
- Attach cover artwork (BMP / JPG / PNG / GIF) — stored as a BLOB inside the
  database.

## Requirements

- Windows (the project targets `net8.0-windows` and uses Windows Forms).
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).
- The **Microsoft Access Database Engine 2016 Redistributable** (or newer),
  which provides the `Microsoft.ACE.OLEDB.12.0` provider used to talk to
  `Database.accdb`. Install the bitness (x86 or x64) that matches the build
  configuration you intend to run.

## Getting started

```sh
# Restore + build
dotnet build

# Run
dotnet run --project MovieDB.csproj
```

`Database.accdb` is copied to the build output directory automatically
(`CopyToOutputDirectory = PreserveNewest` in the project file), and the app
resolves it relative to the executable — so no path configuration is needed.

## Project structure

```
MovieDB/
├── Data/
│   └── DatabaseHelper.cs     # Centralised OLE DB connection string
├── Forms/
│   ├── Form1.cs              # Main window: lists movies
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Form2.cs              # "Add Movie" dialog
│   ├── Form2.Designer.cs
│   └── Form2.resx
├── Properties/
│   ├── Resources.Designer.cs
│   └── Resources.resx
├── Program.cs                # Application entry point
├── Database.accdb            # Access database (schema + data)
├── MovieDB.csproj
└── MovieDB.sln
```

## Database schema

The app expects a single table named `MovieTable` with the following columns:

| Column     | Type        | Notes                          |
|------------|-------------|--------------------------------|
| Title      | Short Text  |                                |
| Director   | Short Text  |                                |
| Genre      | Short Text  |                                |
| Year       | Number      | Integer                        |
| AgeRating  | Short Text  | e.g. `PG`, `15`, `18`          |
| Duration   | Number      | Minutes                        |
| UserRating | Number      | Integer                        |
| Summary    | Long Text   |                                |
| Artwork    | OLE Object  | Raw image bytes, nullable      |

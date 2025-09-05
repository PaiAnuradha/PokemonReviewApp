<h1>Pokemon Review Application</h1>

- UML diagram
 ![UML Diagram](https://github.com/PaiAnuradha/PokemonReviewApp/blob/master/PokemonReview/UMLDiagram.PNG)


- Relationships
  - Pokemon ↔ Owner → Many-to-Many
  - Owner → Country → Many-to-One
  - Pokemon ↔ Category → Many-to-Many
  - Pokemon → Review → One-to-Many
  - Reviewer → Review → One-to-Many

Note:
- Fluent API is used for configuring EF Core models using code instead of data annotations
- Fluent API relationship flow
    - Dependent entity    → Principal entity    → Principal’s collection    → Foreign key    → EF Core builds relationship
- All entity relationships, keys, and constraints are configured within the OnModelCreating method of the DbContext class using Fluent API. This approach keeps the entity classes clean and separates the database configuration from the model definitions.
- Property name Id is configured as primary key(if explicitly not specified) by EF core.


Migration
- set of instructions that tells EF Core how to bring database schema in sync with C# models.
- In Packet Manager Console
  1. Install-Package Microsoft.EntityFrameworkCore.Tools
  2. Add-Migration InitialCreate
  3. Update-Database

    

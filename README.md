<h1>Pokemon Review Application</h1>

- UML diagram
 ![UML Diagram](https://github.com/PaiAnuradha/PokemonReviewApp/blob/master/PokemonReview/UMLDiagram.PNG)


- Relationships
  - Pokemon ↔ Owner → Many-to-Many
  - Owner → Country → Many-to-One
  - Pokemon ↔ Category → Many-to-Many
  - Pokemon → Review → One-to-Many
  - Reviewer → Review → One-to-Many

- Fluent API is used for configuring EF Core models using code instead of data annotations
    
- Relationships 
  Dependent entity    → Principal entity    → Principal’s collection    → Foreign key    → EF Core builds relationship

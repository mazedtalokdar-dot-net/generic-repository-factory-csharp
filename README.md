# generic-repository-factory-csharp
A C# Console Application implementing advanced Design Patterns including Generic Repository and Factory Pattern. This project demonstrates clean code architecture by decoupling data logic from business logic, featuring generic CRUD operations, interface-based design, and dependency management for entities like Orders and Riders.
<h4>Key Features of this Project</h4>
<ul>
  <li>Generic Repository (IRepo<T>): A single interface to handle CRUD operations for any entity inheriting from CommonFeild.</li>
    <li>Factory Pattern (IRepoFectory): Used to decouple the creation logic of repositories, making the system more scalable.</li>
    <li>Abstraction: Centralized CommonFeild class to ensure all models have a consistent base (ID property).</li>
    <li>Test-Driven Logic: Includes a Test.cs class to demonstrate real-time CRUD operations on Orders and Riders data.</li>
</ul>
    <h4>Architecture View</h4>
<strong>Models:</strong> Orders.cs, Riders.cs (Data structure)

<strong>Repository:</strong> IRepo.cs, GeniricRepo.cs (Data Handling)

<strong>Factory:</strong> IRepoFectory.cs, RepoFectoy.cs (Creation Logic)

<strong>Consumer:</strong> Test.cs, Program.cs (Execution)






public enum Gender {Male , Female}
public enum Status {Active , InActive}


public class Student
{
    public int Id {get;set;}
    public string? FirstName {get;set;}
    public string? LastName {get;set;}
    public int Age {get;set;}
    public Gender Gender1 {get;set;}
    public Status Status1 {get;set;}
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfStart {get;set;}
    public DateTime DateOfFinish {get;set;}

}
﻿namespace DataManager.ReturnFields;

public class ReturnToDoItem
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsComplete { get; set; }
    public required string CompleteCountOrStatus { get; set; }
}
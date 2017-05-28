using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be positive number or zero!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minGrade must be positive number or zero!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maxGrade must be smaller or equal than minGrade!");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("The comments must be a sting with length bigger than zero!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
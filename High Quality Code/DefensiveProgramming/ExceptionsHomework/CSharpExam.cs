using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score 
    { 
        get
        {
            return this.score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("CSharp Exam score must be a positive number");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException("Score must be a number between 0 and 100 inclusive");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
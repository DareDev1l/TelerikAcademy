using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            this.problemsSolved = value;

            if (value < 0)
            {
                this.problemsSolved = 0;
            }
            else if (value > 2)
            {
                this.problemsSolved = 2;
            }
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: half done.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Excellent result: everything done.");
        }

        throw new ArgumentOutOfRangeException("ProblemsSolved should be an integer between 0 and 2");
    }
}
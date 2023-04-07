public class Questions 
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;  
    public string optionD;
    public char correctAnswerLetter;
    private static char _defaultCorrectAnswer = 'X';

    // constructor
    public Questions() 
    {
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = _defaultCorrectAnswer;
    }

    public Questions(string questionText)
    {
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = _defaultCorrectAnswer;    

    }

    public Questions(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswer)
    {
        this.questionText = questionText;   
        this.optionA = optionA;
        this.optionB = optionB; 
        this.optionC = optionC; 
        this.optionD = optionD;
        this.correctAnswerLetter = correctAnswer;
    }

    public bool AreOptionsValid()
    {
        int count = 0;

        if(optionA == null)
        {
            count++;
        } 
        else if(optionB == null)
        {
            count++;
        }
        else if(optionC == null)
        {
            count++;
        } else if(optionD == null)
        {
            count++;
        }

        if(count < 2)
        {
            return false;
        }
        return true;

    }
}

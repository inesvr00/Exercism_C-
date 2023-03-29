######################################################################################
# Bob answers 'Sure.' if you ask him a question, such as "How are you?".             #
#                                                                                    #
# He answers 'Whoa, chill out!' if you YELL AT HIM (in all capitals).                #
#                                                                                    #
# He answers 'Calm down, I know what I'm doing!' if you yell a question at him.      #
#                                                                                    #
# He says 'Fine. Be that way!' if you address him without actually saying anything.  #
#                                                                                    #
# He answers 'Whatever.' to anything else.                                           #
######################################################################################

using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        int lastQuestionMarkIndex = statement.Trim().LastIndexOf("?");
        string beforeQuestionMark;

        if (lastQuestionMarkIndex != -1 && lastQuestionMarkIndex == statement.Trim().Length -1)
        {
            beforeQuestionMark = statement.Substring(0, lastQuestionMarkIndex);
            
            if (statement.EndsWith("?") && (statement.ToUpper() == statement) && !beforeQuestionMark.All(c => char.IsDigit(c)) && !beforeQuestionMark.All(c => char.IsPunctuation(c))) return "Calm down, I know what I'm doing!";

            else return "Sure.";
        }
        else 
        {
            if (statement.Trim() == "") return "Fine. Be that way!";
                    
            else if (statement.ToUpper() == statement && statement.Any(c => char.IsLetter(c))) return "Whoa, chill out!";
        
            else return "Whatever.";
        }
    }
}

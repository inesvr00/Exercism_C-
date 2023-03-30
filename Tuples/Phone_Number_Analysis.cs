using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] sep_nums = phoneNumber.Split("-", StringSplitOptions.RemoveEmptyEntries);
        bool IsNewYork = false;
        bool IsFake = false;
    
        if (sep_nums[0] == "212") 
        {
            IsNewYork = true;
        }
    
        if (sep_nums[1] == "555") 
        {
            IsFake = true;
        }
    
        return (IsNewYork, IsFake, sep_nums[2]);
    }


    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake)
            return true;
        else return false;
    }
}

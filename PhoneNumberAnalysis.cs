using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber) =>
        (
            phoneNumber.Split('-')[0] == "212", 
            phoneNumber.Split('-')[1] == "555", 
            phoneNumber.Split('-')[2]
        );

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => 
        phoneNumberInfo.IsFake;
}

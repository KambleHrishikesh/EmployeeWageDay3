﻿//Constants
 const int IS_PART_TIME = 1;
 const int IS_FULL_TIME = 2;
 const int Emp_RATE_PER_HOUR = 20;
 const int NUM_OF_WORKING_DAYS = 20;
 const int MAX_HRS_IN_MONTH = 100;

    //Variables
    int empHrs = 0;
    int totalEmpHrs = 0;
    int totalWorkingDays = 0;

    //Computation
    while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
    {
        //It is using to generate random numbers
        Random random = new Random();
        int empCheck = random.Next(0, 3);// 0,1,2
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;


        }
        totalEmpHrs += empHrs;
        Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
    }
    int totalEmpWage = totalEmpHrs * Emp_RATE_PER_HOUR;
    Console.WriteLine("Total Emp Wage : " + totalEmpWage);
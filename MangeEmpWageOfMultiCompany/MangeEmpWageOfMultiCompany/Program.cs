using System;

namespace MangeEmpWageOfMultiCompany
{
   public class EmpWageBuilderArray
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        private int noOfCompany = 0;
        private companyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new companyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int salaryPerHr, int noOfWorkingDays, int maxHrsPerMonth)
        {
            companyEmpWageArray[this.noOfCompany] = new companyEmpWage(company, salaryPerHr, noOfWorkingDays, maxHrsPerMonth);
            noOfCompany++;
        }
        public void EmpWageUsingClassMethod()
        {
            for(int i = 0; i < noOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.EmpWageUsingClassMethod(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int EmpWageUsingClassMethod(companyEmpWage companyEmpWage)
        {
            int dailyHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.noOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int checkVal = random.Next(0, 3);
         switch(checkVal)
                {
                    case isPartTime:
                        dailyHrs = 4;
                        break;
                    case isFullTime:
                        dailyHrs = 8;
                        break;
                }
                totalEmpHrs += dailyHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp hrs:" + dailyHrs);
            }
            return totalEmpHrs * companyEmpWage.salaryPerHr;
        }
    }
    public class companyEmpWage
    {
        public string company;
        public int salaryPerHr;
        public int noOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;

        public companyEmpWage(string company, int salaryPerHr, int noOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.salaryPerHr = salaryPerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total employee wage for a company:" + this.company + "is:" + this.totalEmpWage;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
        }
    }
    }
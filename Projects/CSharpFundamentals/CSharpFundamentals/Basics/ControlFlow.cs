namespace CSharpFundamentals.Basics
{
    public class ControlFlow
    {
        public static void ControlFlowDemo()
        {
            Console.Write("Please enter your credit score: ");
            
            int creditScore = int.Parse(Console.ReadLine());

            string loanApproval = creditScore switch
            {
                >= 750 => "Approved with best rates!",
                >= 650 => "Approved with standard rates",
                _ => "Loan denied. Improve your credit score."
            };

            Console.WriteLine(loanApproval);
        }
    }
}

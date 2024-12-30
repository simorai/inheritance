namespace inheritance.Entities
{
    /// <summary>
    /// Representa uma conta bancária para negócios, herdando da classe Account.
    /// </summary>
    internal class BusinessAccount : Account
    {
        /// <summary>
        /// Obtém ou define o limite de empréstimo para a conta de negócios.
        /// </summary>
        public double LoanLimit { get; set; }

        /// <summary>
        /// Construtor padrão para a classe BusinessAccount.
        /// </summary>
        public BusinessAccount() { }

        /// <summary>
        /// Construtor que inicializa uma nova conta de negócios com número, titular, saldo e limite de empréstimo especificados.
        /// </summary>
        /// <param name="number">O número da conta.</param>
        /// <param name="holder">O nome do titular da conta.</param>
        /// <param name="balance">O saldo inicial da conta.</param>
        /// <param name="loanLimit">O limite de empréstimo para a conta.</param>
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        /// <summary>
        /// Realiza um empréstimo para a conta de negócios, desde que o valor não exceda o limite de empréstimo.
        /// </summary>
        /// <param name="amount">O valor do empréstimo solicitado.</param>
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

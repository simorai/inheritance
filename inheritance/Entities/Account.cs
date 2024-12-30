namespace inheritance.Entities
{
    /// <summary>
    /// Representa uma conta bancária.
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// Obtém o número da conta. Este valor só pode ser definido internamente.
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Obtém o nome do titular da conta. Este valor só pode ser definido internamente.
        /// </summary>
        public String Holder { get; private set; }
        /// <summary>
        /// Obtém o saldo atual da conta. Este valor pode ser modificado por classes derivadas.
        /// </summary>
        public double Balance { get; protected set; }

        /// <summary>
        /// Construtor padrão para a classe Account.
        /// </summary>
        public Account() { }

        /// <summary>
        /// Construtor que inicializa uma nova conta com número, titular e saldo especificados.
        /// </summary>
        /// <param name="number">O número da conta.</param>
        /// <param name="holder">O nome do titular da conta.</param>
        /// <param name="balance">O saldo inicial da conta.</param>
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        /// <summary>
        /// Realiza um saque da conta.
        /// </summary>
        /// <param name="amount">O valor a ser sacado.</param>
        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        /// <summary>
        /// Realiza um depósito na conta.
        /// </summary>
        /// <param name="amount">O valor a ser depositado.</param>
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

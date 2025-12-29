namespace LPU_Exceptions
{
    ///<summary>
    ///Custom Exception Class Created for LPU Project
    ///By Pawas on Date 29/12/2025 at 11:35AM
    ///</summary>
    public class LPUException : Exception
    {
        public LPUException() : base()
        {

        }
        public LPUException(string errorMsg) : base(errorMsg)
        {

        }
    }
}

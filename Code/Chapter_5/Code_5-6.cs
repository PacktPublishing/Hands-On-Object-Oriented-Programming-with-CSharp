using System;

namespace Chapter5
{
    class Code_5_6
    {
        static void Main(string[] args)
        {
            try
            {
                // Step 1: Established database connection
                // Step 2: Do some activity in database
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle IndexOutOfRangeExceptions here
            }
            catch (DivideByZeroException ex)
            {
                // Handle DivideByZeroException here
            }
            catch
            {
                // Handle All other exception here
            }

            finally
            {
                // Close the database connection
            }

        }
    }
}
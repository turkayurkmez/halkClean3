namespace Functions
{
    //Amaç: Bir dosyadaki verileri alıp işleyerek bir pdf formatında rapora dönüştürür.
    public class ReportGenerator
    {
        public ReportGenerator(string excelFilePath)
        {
            ////1. verilen adreste dosya var mı?
            //if (!File.Exists(excelFilePath))
            //{
            //    //2. dosya varsa formata uygun mu?
            //    if (!isFormatIsExpected(excelFilePath))
            //    {

            //    }
            //}

            try
            {
                validateFile(excelFilePath);
            }
            catch (Exception exception)
            {

                throw exception;
            }

        }

        private bool isFileExists(string path)
        {
            return File.Exists(path);
        }
        private bool isFormatIsExpected(string path)
        {
            return false;
        }



        private bool isValidatedFile(string path)
        {
            return !isFileExists(path) &&
                   !isFormatIsExpected(path);

        }


        private void validateFile(string path)
        {
            if (!isValidatedFile(path))
            {
                throw new FileNotFoundException();

            }
        }
    }
}

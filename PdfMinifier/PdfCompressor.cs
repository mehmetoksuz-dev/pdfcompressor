namespace PdfMinifier
{
    public class PdfCompressor
    {
        private static string sourceFolder;
        private static string targetFolder;

        public PdfCompressor(string source, string target)
        {
            sourceFolder = source;
            targetFolder = target;
            IronPdf.License.LicenseKey = "IRONSUITE.MEHMET.8000.HOTMAIL.COM.20923-2919589B65-I6BVG-VZ5LQLNDPFHY-DAILC7VKWPVQ-SHYVI57VF6H6-N5XAEMY5YZRA-LBGVENKFKMDF-AMN3KEAMBGYA-MY7DY7-TGS3X6G6RLKNUA-DEPLOYMENT.TRIAL-JWRCOT.TRIAL.EXPIRES.16.OCT.2024";
        }

        public void CompressPdfFiles(int quality = 60)
        {
            if (string.IsNullOrEmpty(sourceFolder) || string.IsNullOrEmpty(targetFolder))
            {
                throw new InvalidOperationException("Source and target folders must be set.");
            }

            if (!Directory.Exists(sourceFolder))
            {
                throw new DirectoryNotFoundException($"Source folder '{sourceFolder}' not found.");
            }

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            var pdfFiles = Directory.GetFiles(sourceFolder, "*.pdf");
            foreach (var pdfFile in pdfFiles)
            {
                CompressPdfFile(pdfFile, quality);
            }
        }

        private void CompressPdfFile(string filePath, int quality)
        {
            try
            {
                var fileName = Path.GetFileName(filePath);
                var targetPath = Path.Combine(targetFolder, fileName);

                var pdf = new PdfDocument(filePath);
                pdf.CompressImages(quality);
                pdf.SaveAs(targetPath);

                Console.WriteLine($"Compressed {filePath} and saved to {targetPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file {filePath}: {ex.Message}");
            }
        }
    }

}

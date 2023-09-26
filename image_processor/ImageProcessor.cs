using System;
using System.Drawing;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            try
            {
                // Load the original image
                using (Bitmap originalImage = new Bitmap(filename))
                {
                    // Create a new bitmap for the inverted image
                    Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

                    // Loop through each pixel in the original image
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        for (int y = 0; y < originalImage.Height; y++)
                        {
                            // Get the color of the current pixel
                            Color originalColor = originalImage.GetPixel(x, y);

                            // Invert the color by subtracting each RGB component from 255
                            Color invertedColor = Color.FromArgb(
                                255 - originalColor.R,
                                255 - originalColor.G,
                                255 - originalColor.B
                            );

                            // Set the inverted color in the new image
                            invertedImage.SetPixel(x, y, invertedColor);
                        }
                    }

                    // Save the inverted image with a new filename
                    string[] parts = filename.Split('.');
                    string newFilename = $"{parts[0]}_inverse.{parts[1]}";
                    invertedImage.Save(newFilename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filename}: {ex.Message}");
            }
        }
    }
}


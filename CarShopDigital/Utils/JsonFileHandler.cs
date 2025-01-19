using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShopDigital.Utils
{
    public class JsonFileHandler
    {
        public static async Task WriteToJson<T>(string filePath, T data)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving JSON file: {ex.Message}");
            }
        }

        public static async Task<T> ReadFromJson<T>(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                string jsonString = await File.ReadAllTextAsync(filePath);
                var result = JsonSerializer.Deserialize<T>(jsonString);
                if (result == null)
                    throw new InvalidOperationException("Failed to deserialize JSON: Result was null");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading JSON file: {ex.Message}");
            }
        }
    }
}
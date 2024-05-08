using System.Text.Json;
using System.Xml.Linq;

namespace VisionSystemConfigFile
{
    public class ConfigFile
    {
        public static void SaveConfig(ProjectConfig ProjectConfig)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string fileName = $"{ProjectConfig.ProjectPath}\\{ProjectConfig.ProjectName}.json";
            string jsonString = JsonSerializer.Serialize<ProjectConfig>(ProjectConfig, options);
            File.WriteAllText(fileName, jsonString);
        }
        public static ProjectConfig LoadConfig(string jsonFilePath) 
        {

            // Verificar si el archivo existe
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    // Leer el contenido del archivo JSON
                    string jsonString = File.ReadAllText(jsonFilePath);

                    // Deserializar el JSON a un objeto C#
                    ProjectConfig config = JsonSerializer.Deserialize<ProjectConfig>(jsonString);
                    return config;
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
            }
            return new ProjectConfig();
        }

    }
}

package utils;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Properties;

public class ConfigUtils {
    public static String resourceData = "src/test/resources/";
    public static Properties getProps(String fileName){
        Properties properties = new Properties();
        try {
            File propFile = new File(resourceData+fileName+".properties");
            if (propFile.exists())
                properties.load(new FileInputStream(propFile));
            else
                System.out.println("File Not Found");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
        return  properties;
    }
}

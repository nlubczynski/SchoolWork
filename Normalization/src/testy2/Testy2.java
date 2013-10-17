package testy2;
import javax.xml.parsers.DocumentBuilder;
import org.xml.sax.SAXException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource; 
import javax.xml.transform.stream.StreamResult; 
import org.w3c.dom.Document;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.*; 

public class Testy2 {

    public static void main(String[] args) {
            
        // Just put your input file path, and output path
        // The Schema can be recognized by Namespaces in your XML file
        
            String PATH_NAME="";
            String YOUR_INPUT_XML_FILE_NAME="WebTechAssignment2.xml";
            String YOUR_OUTPUT_NORMALIZED_FILE_NAME="Normalized_XML_File.xml";
            
            String inputXML_file=PATH_NAME+YOUR_INPUT_XML_FILE_NAME;
            String NormalizedXML_file=PATH_NAME+YOUR_OUTPUT_NORMALIZED_FILE_NAME;
            String SCHEMA_LANGUAGE = "http://java.sun.com/xml/jaxp/properties/schemaLanguage";
            String XML_SCHEMA = "http://www.w3.org/2001/XMLSchema";
            
            try {
                DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
                dbf.setNamespaceAware(true);
                dbf.setValidating(true);
                dbf.setAttribute(SCHEMA_LANGUAGE, XML_SCHEMA );
                dbf.setFeature("http://apache.org/xml/features/dom/include-ignorable-whitespace",false);
                DocumentBuilder parser = dbf.newDocumentBuilder();
                Document document = parser.parse(new File(inputXML_file).toURI().toString());
                document.normalizeDocument(); // THE NORMALIZTION 
                System.out.println("Your file is valied, and your normalized copy is in ("+NormalizedXML_file+").");
            
                File outputFile= new File(NormalizedXML_file);
                TransformerFactory tFactory =
                TransformerFactory.newInstance();
                Transformer transformer = tFactory.newTransformer();
                DOMSource source = new DOMSource(document);
                StreamResult result = new StreamResult(outputFile); //xmlfile
                transformer.transform(source, result);
            }        
            catch (SAXException e) {
            // exception handling - document not valid!
            System.out.println(e.toString());
            } catch (IOException e) {
            // exception handling
            System.out.println(e.toString());
            } catch (Throwable t) {
            t.printStackTrace ();
            }       
    }
}

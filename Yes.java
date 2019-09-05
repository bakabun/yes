import java.io.BufferedOutputStream;
import java.io.IOException;

public class Yes {
    public static void main(String[] args) {
        final int MAX_BUFFER_SIZE = 65536;
        String inputString = args.length > 1 ? args[1] + '\n' : "y\n";

        StringBuilder bufferString = new StringBuilder();
        for (int i = MAX_BUFFER_SIZE; i > 0; i -= inputString.length()) {
            bufferString.append(inputString);
        }

        byte[] byteOutput = bufferString.toString().getBytes();
        try (BufferedOutputStream os = new BufferedOutputStream(System.out)) {
            while(true) 
                os.write(byteOutput);
        } catch (IOException e) {
            System.err.println(e.getLocalizedMessage());
        }
    }
}

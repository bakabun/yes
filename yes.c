#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>

#define BUF_MAX_SIZE 65536

int main(int argc, char *argv[]) {
    char *buffer = calloc(BUF_MAX_SIZE, sizeof(char));
    char *y = "y\n";
    char *input_string = y;
    int input_length = strlen(y);

	if (argc > 1) {
		char *input = argv[1];
		input_length = strlen(input) + 1;
		input[input_length - 1] = '\n';
        input_string = input;
	}

	if (input_length <= sizeof(buffer)) {
        int buffer_length = 0;
		while (buffer_length < (sizeof(buffer) - 1) - input_length) {
			memcpy(buffer + buffer_length, input_string, input_length);
			buffer_length += input_length;
		}
	}

	while(1) write(1, buffer, BUF_MAX_SIZE);
    
    return 1;
}
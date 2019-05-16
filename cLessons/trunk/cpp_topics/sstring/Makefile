CC=g++ 
CXXFLAGS=-std=c++0x
CFLAGS=-I.
DEP=string.h
OBJECTS=main.o sstring.o
LIBS=

sstringtest: $(OBJECTS)
	$(CC) $(CXXFLAGS) $(LIBS) $(CFLAGS) $^ -o $@

%.o: %.cpp $(DEP)
	$(CC) $(CXXFLAGS) $(LIBS) $(CFLAGS) -c $< -o $@

clean:
	rm $(OBJECTS) sstringtest
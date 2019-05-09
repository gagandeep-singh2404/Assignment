#include "sstring.h"

class LineNode
{
private:
   LineNode *next;
   SString data;
public:
   // constructor of LineNode 
   LineNode(const SString &data);
   // methods 
   LineNode* getNext();
   void appendNextNode(LineNode &next);
   void printLine();
};

#include <iostream>
#include <string.h>
#include "sstring.h"

using namespace std;

SString::SString() {
  len =0;
  p = NULL;
}

SString::SString(const char *ps) {
  len = strlen(ps);
  p = new char[len + 1] ;
  strcpy(p, ps);
}

void SString::set(const SString &b) {
  delete [] p;
  len = b.len;
  p = new char[len + 1];
  strcpy (p, b.p);
}

void SString::andOp(const SString &b) {
  char *pBuf;
  int lBuf;
  
  lBuf = len + b.len;
  pBuf = new char[lBuf + 1];
  
  if (p!=NULL) { 
    strcpy(pBuf,p);
    strcat(pBuf,b.p);
  }
  else strcpy(pBuf,b.p);
  
  delete [] p;
  
  p = pBuf;
  len = lBuf;
}

SString& SString::operator=(const SString& s) {
  if (&s != this) { //be aware for u=u, why???
    delete [] p; //delete the old string
    len=s.len;
    p=new char[ len + 1];
    strcpy(p, s.p);
  }
  return *this;
}

SString::~SString() { 
  delete [] p; 
}
 
void SString::print() {
  if (p != NULL)  cout << p << endl;
}
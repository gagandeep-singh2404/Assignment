#include "sstring.h"
#include "lineNode.h"
int main() {
  SString s("a string");
  SString u;
  SString t(" is a string");
  SString v("b string ");
  SString w("another string");
  s.print();  
  u.print();
  u.andOp(s); 
  u.print();
  u.set(v); 
  u.andOp(t); 
  u.print();
  return 0;
}
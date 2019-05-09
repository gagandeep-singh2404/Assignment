#include "sstring.h"

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
  //w=u; //assignment, results in compiler error when operator= is missing
  w.print();
  return 0;
}
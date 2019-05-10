#ifndef _SSTRING_H
#define	_SSTRING_H

class SString {
public:
// constructors
  SString();
  SString(const char *ps);
  SString(SString &s);
  ~SString(); 
  // methods
  void set(const SString &b);
  void andOp(const SString &b);
  SString& operator=(const SString& s);
  void print(); 
private:
  int len;
  char *p;
};

#endif	/* _SSTRING_H */
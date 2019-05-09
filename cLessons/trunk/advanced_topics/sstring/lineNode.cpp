#include "lineNode.h"
#include <string.h>

LineNode::LineNode(const SString &newData){
    data.set(newData);
    next = nullptr;
}

LineNode* LineNode::getNext(){
    return this->next;
}
void LineNode::appendNextNode(LineNode& node){
    this->next = &node;
}

void LineNode::printLine(){
    return this->data.print;
}
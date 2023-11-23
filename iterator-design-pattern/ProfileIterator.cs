namespace iterator_design_pattern;

public interface ProfileIterator
{
    FacebookProfile GetNext();
    bool HasNext();
}
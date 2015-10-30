namespace MyData.domain
{
    public interface Validator<E>
    {
        void Validate(E e);
    }
}
namespace BinaryTree;

/// <summary>
/// Создать реализацию структуры данных Бинарное Дерево.
/// Узлы дерева содержат значения типа uint/UInt32.
/// Дерево должно быть максимально сбалансировано.
/// Т.е. длина максимальной ветви правого поддерева должна отличаться
/// от длина максимальной ветви левого поддерева максимум на 1.
/// Реализовать методы Add и MaxBranchSum.
/// Должна быть возможность перебора дерева через цикл foreach. 
/// Метод перебора - любой.
/// </summary>
public class BinaryTree
{
    /// <summary>
    /// Метод добавляет в дерево новый узел со значением value.
    /// </summary>
    /// <param name="value">Добавляемое значение.</param>
    public virtual void Add(uint value)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод ищет максимальную сумму значений узлов от корня дерева до листа дерева.
    /// </summary>
    public virtual uint MaxBranchSum()
    {
        throw new NotImplementedException();
    }
}

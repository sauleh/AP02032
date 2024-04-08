using System.Collections;

public class TokenEnumerator : IEnumerator<string>
{
    private string m_str;
    private string[] m_tokens;
    private int m_current_token;

    public TokenEnumerator(string str)
    {
        this.m_str = str;
        m_tokens = m_str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        m_current_token = -1;
    }

    public string Current 
    {
        get
        {
            return m_tokens[m_current_token];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return m_tokens[m_current_token];
        }
    }

    public void Dispose() {}

    public bool MoveNext()
    {
        m_current_token++;
        return m_current_token < m_tokens.Length;
    }

    public void Reset()
    {
        m_current_token = -1;
    }
}


public class TokenizedString: IEnumerable<string>
{
    private string m_str;

    public TokenizedString(string str)
    {
        this.m_str = str;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new TokenEnumerator(this.m_str);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new TokenEnumerator(this.m_str);
    }
}
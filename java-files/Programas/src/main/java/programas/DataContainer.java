//
// DataContainer.java
//
package programas;

import java.io.Serial;
import java.io.Serializable;
import java.math.BigDecimal;

public class DataContainer implements Serializable
{
    @Serial
    private static final long serialVersionUID = 9L;

    private Object object;
    private Character unCharacter;
    private String unString;
    private Integer numInteger;
    private Float numFloat;
    private Double numDouble;
    private BigDecimal numBigDecimal;

    public DataContainer()
    {
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;

        DataContainer that = (DataContainer) o;
        return object.equals(that.object) && unCharacter.equals(that.unCharacter) && unString.equals(that.unString) && numInteger.equals(that.numInteger) && numFloat.equals(that.numFloat) && numDouble.equals(that.numDouble) && numBigDecimal.equals(that.numBigDecimal);
    }

    @Override
    public int hashCode() {
        int result = object.hashCode();
        result = 31 * result + unCharacter.hashCode();
        result = 31 * result + unString.hashCode();
        result = 31 * result + numInteger.hashCode();
        result = 31 * result + numFloat.hashCode();
        result = 31 * result + numDouble.hashCode();
        result = 31 * result + numBigDecimal.hashCode();
        return result;
    }

    @Override
    public String toString() {
        return "DataContainer {" +
                "object=" + object +
                ", unCharacter=" + unCharacter +
                ", unString='" + unString + '\'' +
                ", numInteger=" + numInteger +
                ", numFloat=" + numFloat +
                ", numDouble=" + numDouble +
                ", numBigDecimal=" + numBigDecimal +
                '}';
    }

    public Object getObject() {
        return object;
    }

    public void setObject(Object object) {
        this.object = object;
    }

    public Character getUnCharacter() {
        return unCharacter;
    }

    public void setUnCharacter(Character unCharacter) {
        this.unCharacter = unCharacter;
    }

    public String getUnString() {
        return unString;
    }

    public void setUnString(String unString) {
        this.unString = unString;
    }

    public Integer getNumInteger() {
        return numInteger;
    }

    public void setNumInteger(Integer numInteger) {
        this.numInteger = numInteger;
    }

    public Float getNumFloat() {
        return numFloat;
    }

    public void setNumFloat(Float numFloat) {
        this.numFloat = numFloat;
    }

    public Double getNumDouble() {
        return numDouble;
    }

    public void setNumDouble(Double numDouble) {
        this.numDouble = numDouble;
    }

    public BigDecimal getNumBigDecimal() {
        return numBigDecimal;
    }

    public void setNumBigDecimal(BigDecimal numBigDecimal) {
        this.numBigDecimal = numBigDecimal;
    }
}
